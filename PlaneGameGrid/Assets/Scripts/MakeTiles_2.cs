using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeTiles_2 : MonoBehaviour {

	// This first list contains every vertex of the mesh that we are going to render
	public List<Vector3> newVertices = new List<Vector3>();
	
	// The triangles tell Unity how to build each section of the mesh joining
	// the vertices
	public List<int> newTriangles = new List<int>();
	
	// The UV list is unimportant right now but it tells Unity how the texture is
	// aligned on each polygon
	public List<Vector2> newUV = new List<Vector2>();
	
	
	// A mesh is made up of the vertices, triangles and UVs we are going to define,
	// after we make them up we'll save them as this mesh
	private Mesh mesh;

	private int squareCount = 0;

	public byte[,] blocks;

	public int z = -4;

	void Start () {
		mesh = GetComponent<MeshFilter> ().mesh;

		BuildMesh ();
		UpdateMesh ();
	}

	void BuildMesh(){
		blocks = new byte[8,8];

		for(int px=0;px<blocks.GetLength(0);px++){
			for(int py=0;py<blocks.GetLength(1);py++){

					GenSquare(px,py);
				}
				
			}
		}

	void GenSquare(int x, int y) {
		newVertices.Add( new Vector3 (x  , y  , z ));
		newVertices.Add( new Vector3 (x + 1 , y  , z ));
		newVertices.Add( new Vector3 (x + 1 , y-1  , z ));
		newVertices.Add( new Vector3 (x  , y-1  , z ));
		
		newTriangles.Add(squareCount*4);
		newTriangles.Add((squareCount*4)+1);
		newTriangles.Add((squareCount*4)+3);
		newTriangles.Add((squareCount*4)+1);
		newTriangles.Add((squareCount*4)+2);
		newTriangles.Add((squareCount*4)+3);
		
		squareCount++;
	}

	void UpdateMesh() {

		mesh.Clear ();
		mesh.vertices = newVertices.ToArray();
		mesh.triangles = newTriangles.ToArray();
		mesh.Optimize ();
		mesh.RecalculateNormals ();
		
		squareCount = 0;
		newVertices.Clear();
		newTriangles.Clear();
		newUV.Clear();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
