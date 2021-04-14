using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOWPATH : MonoBehaviour
{
    // objetivo
    //Transform goal;
    // valor da velocidade
    //public float speed = 5.0f;
    // valor da precisão
    //public float accuracy = 1.0f;
    // valor da rotação
    //public float rotSpeed = 2.0f;

    // Indentificar o wpmanager
    public GameObject wpManager;
    // index
    GameObject[] wps;
    UnityEngine.AI.NavMeshAgent agent;
    // nós
   // GameObject currentNode;
    // origem
   // int currentWP = 0;
    // graph
   //Graph g;

    void Start()
    {
        // chamando componentes
        wps = wpManager.GetComponent<WPManager>().waypoints;
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        //g = wpManager.GetComponent<WPManager>().graph;
        //currentNode = wps[0];
    }

    // leva voce para o Heliporto
    public void GoToHeli()
    {
        agent.SetDestination(wps[1].transform.position);
        //g.AStar(currentNode, wps[1]);
        //currentWP = 0;
    }

    // leva voce para a Ruina
    public void GoToRuin()
    {
        agent.SetDestination(wps[6].transform.position);
        //g.AStar(currentNode, wps[6]);
        //currentWP = 0;
    }

    // leva voce para a Industria
    public void GoToIndustry()
    {
        agent.SetDestination(wps[9].transform.position);
        //g.AStar(currentNode, wps[9]);
        //currentWP = 0;
    }

    void LateUpdate()
    {
       /*  ================ CODIGO DO WAYPOINT =================
        // tamanho da caminhada
        if (g.getPathLength() == 0 || currentWP == g.getPathLength())
            return;

        //nó atual mais próximo
        currentNode = g.getPathPoint(currentWP);

        // quando chegar perto de um nó, se mova para o próximo 
        if (Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        {
            currentWP++;
        }

        // faz a movimentação para outro sentido, mirando em outro ponto
        if (currentWP < g.getPathLength())
        {
            goal = g.getPathPoint(currentWP).transform;
            Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
            Vector3 direction = lookAtGoal - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        }

        transform.Translate(0, 0, speed * Time.deltaTime);*/
    }
}
