//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//
//[RequireComponent (typeof(MeshFilter))]
//[RequireComponent (typeof(MeshRenderer))]
//[RequireComponent (typeof(MeshCollider))]
//[RequireComponent (typeof(Material))]
//
//// This first list contains every vertex of the mesh that we are going to render
//public List<Vector3> newVertices = new List<Vector3>();
//
//// The triangles tell Unity how to build each section of the mesh joining
//// the vertices
//public List<int> newTriangles = new List<int>();
//
//// The UV list is unimportant right now but it tells Unity how the texture is
//// aligned on each polygon
//public List<Vector2> newUV = new List<Vector2>();
//
//
//// A mesh is made up of the vertices, triangles and UVs we are going to define,
//// after we make them up we'll save them as this mesh
//private Mesh mesh;
//
//public Material mat;
//
//public class MakeTiles : MonoBehaviour {
//
//	//Make 2D array
//	Mesh[,] grid = new Mesh[8, 8];
//
//	// Update is called once per frame
//	Mesh BuildMesh (int x, int y) {
//
//		Vector3[] verticies = new Vector3[4];
//		int[] triangles = new int[6];
//		Vector3[] normals = new Vector3[4];
//
//		verticies [0] = new Vector3 (0+x, 0-y, 0);
//		verticies [1] = new Vector3 (1+x, 0-y, 0);
//		verticies [2] = new Vector3 (0+x, -1-y, 0);
//		verticies [3] = new Vector3 (1+x, -1-y, 0);
//
//		triangles [0] = 0;
//		triangles [1] = 3;
//		triangles [2] = 2;
//
//		triangles [3] = 0;
//		triangles [4] = 1;
//		triangles [5] = 3;
//
//		normals [0] = Vector3.forward;
//		normals [1] = Vector3.forward;
//		normals [2] = Vector3.forward;
//		normals [3] = Vector3.forward;
//
//		Mesh mesh = new Mesh ();
//
//		mesh.vertices = verticies;
//		mesh.triangles = triangles;
//		mesh.normals = normals;
//
//		MeshFilter mesh_filter = GetComponent<MeshFilter> ();
//		MeshRenderer mesh_renderer = GetComponent<MeshRenderer> ();
//		MeshCollider mesh_meshcollider = GetComponent<MeshCollider> ();
//		
//		mesh_filter.mesh = mesh;
//		mesh_renderer.material = mat;
//
//		return mesh;
//	}
//
//	// Use this for initialization
//	void Start () {
//		
//		for (int i=0; i<grid.GetLength(0); i++) {
//			for (int j=0; i<grid.GetLength(1); i++)
//			{
//				mesh = BuildMesh(i,j);
//				grid[i,j] = mesh;
//			}
//		}
//	}
//	
//	void Update () {
//		mesh.Clear ();
//		//mesh.vertices = newVertices.ToArray();
//		//mesh.triangles = newTriangles.ToArray();
//		//mesh.uv = newUV.ToArray(); // add this line to the code here
//		mesh.Optimize ();
//		mesh.RecalculateNormals ();
//	}
//}
