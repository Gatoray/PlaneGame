using UnityEngine;
using System.Collections;

[RequireComponent (typeof(MeshFilter))]
[RequireComponent (typeof(MeshRenderer))]
[RequireComponent (typeof(MeshCollider))]
public class MakeTiles : MonoBehaviour {



	// Use this for initialization
	void Start () {
		BuildMesh ();
	}
	
	// Update is called once per frame
	void BuildMesh () {

		Vector3[] verticies = new Vector3[4];
		int[] triangles = new int[6];
		Vector3[] normals = new Vector3[4];

		verticies [0] = new Vector3 (0, 0, 0);
		verticies [1] = new Vector3 (1, 0, 0);
		verticies [2] = new Vector3 (0, 0, -1);
		verticies [3] = new Vector3 (1, 0, -1);

		triangles [0] = 0;
		triangles [1] = 3;
		triangles [2] = 2;

		triangles [3] = 0;
		triangles [4] = 1;
		triangles [5] = 3;

		normals [0] = Vector3.up;
		normals [1] = Vector3.up;
		normals [2] = Vector3.up;
		normals [3] = Vector3.up;

		
		Mesh mesh = new Mesh ();

		mesh.vertices = verticies;
		mesh.triangles = triangles;
		mesh.normals = normals;

		MeshFilter mesh_filter = GetComponent<MeshFilter> ();
		MeshRenderer mesh_renderer = GetComponent<MeshRenderer> ();
		MeshCollider mesh_meshcollider = GetComponent<MeshCollider> ();

		mesh_filter.mesh = mesh;
	}
}
