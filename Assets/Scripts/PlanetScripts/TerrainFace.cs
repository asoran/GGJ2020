using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainFace {
    ShapeGenerator shapeGenerator;
    Mesh mesh;
    int resolution;
    Vector3 localUp; //Z Up Local Axis
    Vector3 axisA;
    Vector3 axisB;

    public TerrainFace (ShapeGenerator shapeGenerator, Mesh mesh, int resolution, Vector3 localUp) {
        this.shapeGenerator = shapeGenerator;
        this.mesh = mesh;
        this.resolution = resolution;
        this.localUp = localUp;

        axisA = new Vector3 (localUp.y, localUp.z, localUp.x);
        axisB = Vector3.Cross (localUp, axisA);
    }

    public void ConstructMesh () {
        Vector3[] vertices = new Vector3[resolution * resolution]; // tableau de res * res vecteurs (vertices)
        int[] triangles = new int[(resolution - 1) * (resolution - 1) * 6]; //triangles = (res - 1)² * 2(face = deux triangles) * 3 (nb vertices ds triangle)  
        int triIndex = 0; //index des vertices pour créer les triangles

        for (int y = 0; y < resolution; y++) {
            for (int x = 0; x < resolution; x++) {
                int i = x + y * resolution; //pareil que fait un i++ a la fin de cette boucle
                Vector2 percent = new Vector2 (x, y) / (resolution - 1); //pourcentage pour voir ou le vertex se situe sur la face
                Vector3 pointOnUnitCube = localUp + (percent.x - .5f) * 2 * axisA + (percent.y - .5f) * 2 * axisB;
                Vector3 pointOnUnitSphere = pointOnUnitCube.normalized; //éloigne toutes les vertices à distances égales du centres (carré->sphere) 
                vertices[i] = shapeGenerator.CalculatePointOnPlanet (pointOnUnitSphere);

                if (x != resolution - 1 && y != resolution - 1) {
                    //creation triangle haut
                    triangles[triIndex] = i;
                    triangles[triIndex + 1] = i + resolution + 1;
                    triangles[triIndex + 2] = i + resolution;

                    //creation triangle bas
                    triangles[triIndex + 3] = i;
                    triangles[triIndex + 4] = i + 1;
                    triangles[triIndex + 5] = i + resolution + 1;
                    triIndex += 6;
                }

            }
        }
        mesh.Clear (); //nettoyer la data du mesh (pour éviter les erreurs si on recalculate le mesh avec une résolution plus basse)
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals ();
    }

}