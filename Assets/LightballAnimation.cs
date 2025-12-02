using UnityEngine;

public class LightballAnimation : MonoBehaviour

    {
        public float moveDistance=1f;

        public float moveSpeed=0.5f;

        private Vector3 startPos;

        private Vector3 endPos;

        private bool goToEnd=true;

        private void start()
        {
            startPos = transform.position;
            endPos = new Vector3(startPos.x,startPos.y + moveDistance,startPos.z);

        }

        private void FixedUpdate()
        {
            if(goToEnd)
            {
                transform.position = Vector3.MoveTowards(transform.position,endPos,moveSpeed*Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,startPos,moveSpeed*Time.deltaTime);
            }

            if(Vector3.Distance(transform.position,endPos)<=0.001 &&goToEnd==true)
            {
                goToEnd = false;

            }
            else if(Vector3.Distance(transform.position,startPos)<=0.001 &&goToEnd==false)
            {
                goToEnd = true;
            }
        }
    }
    
    
