using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(LineRenderer))]

public class NodeConnection : NetworkBehaviour {

	//The two nodes that should be connected
	public Node[] nodesBeingConnected = new Node[2];

	LineRenderer lr;
	Vector3[] positions = new Vector3[2];

	void Start () {

		//Store line renderer in lr
		lr = GetComponent<LineRenderer>();
		//Get the positions of both the nodes
		positions[0] = nodesBeingConnected[0].transform.position;
		positions[1] = nodesBeingConnected[1].transform.position;

		//Tell the two nodes being connected that they are connected to each other
		nodesBeingConnected [0].nodeConnections.Add (nodesBeingConnected [1]);
		nodesBeingConnected [1].nodeConnections.Add (nodesBeingConnected [0]);

		//Set the line renderer to the the correct positions and turn it on
		lr.SetPositions(positions);
		lr.enabled = true;
	}

}
