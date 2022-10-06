using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Shady
{
    public class Draw : MonoBehaviour
    {
        [SerializeField] Camera Cam;
        [SerializeField] LineRenderer trailPrefab = null;

        private LineRenderer currentTrail;
        private List<Vector3> points = new List<Vector3>();

        void Start()
        {
            if(!Cam)
            {
                Cam = Camera.main;
            }//if end
        }//Start() eend

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CreateNewLine();
            }

            if (Input.GetMouseButton(0))
            {
                AddPoint();
            }
        }
        public void BackToMainMenuFromQuiz()
        {
            SceneManager.LoadScene("MainMenu");
        }
        public void ResetLineRenderer()
        {
            if (transform.childCount != 0)
            {
                foreach (Transform R in transform)
                {
                    Destroy(R.gameObject);
                }
            }
        }
        private void CreateNewLine()
        {
            currentTrail = Instantiate(trailPrefab);
            currentTrail.transform.SetParent(transform, true);
            points.Clear();
        }//CreateCurrentTrail() end
 
        private void UpdateLinePoints()
        {
            if(currentTrail != null && points.Count > 1)
            {
                currentTrail.positionCount = points.Count;
                currentTrail.SetPositions(points.ToArray());
            }//if end
        }//UpdateTrailPoints() end

        private void AddPoint()
        {
            var Ray = Cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                if(hit.collider.CompareTag("Writeable"))
                {
                    // points.Add(new Vector3(hit.point.x, 0f, hit.point.z));
                    points.Add(hit.point);
                    UpdateLinePoints();
                    return;
                }//if end
                else
                    return;
            }//if end
        }//AddPoint() end

    }//class end
}//namespace end