using System;
using System.Collections;
using System.Collections.Generic;
public class Vertex
{
  public bool wasVisited;
  public string label;
  public Vertex(string label)
  {
    this.label = label;
    wasVisited = false;
  }
}
public class Graph
{
  private int NUM_VERTICES;
  private Vertex[] vertices;
  private int[,] adjMatrix;
  int numVerts;
  public Graph(int number_of_vertex)
  {
    NUM_VERTICES = number_of_vertex;
    vertices = new Vertex[NUM_VERTICES];
    adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
    numVerts = 0;
    for (int j = 0; j < NUM_VERTICES; j++)
      for (int k = 0; k < NUM_VERTICES; k++)
        adjMatrix[j, k] = 0;
  }
  public void AddVertex(string label)
  {
    vertices[numVerts] = new Vertex(label);
    numVerts++;
  }
  public void AddEdge(int start, int eend)
  {
    adjMatrix[start, eend] = 1;
    adjMatrix[eend, start] = 1;
  }
  public void AddEdge(string source, string target){
    int start = -1, eend = -1;
    for(int i=0; i<vertices.Length; i++){
      if(vertices[i].label.Equals(source))
        start = i;
      if(vertices[i].label.Equals(target))
        eend = i;
    }
    AddEdge(start, eend);
  }
  public void AddEdgeDiGraph(int start, int eend)
  {
    adjMatrix[start, eend] = 1;
    //adjMatrix[eend, start] = 1;
  }
  public void AddEdgeDiGraph(string source, string target){
    int start = -1, eend = -1;
    for(int i=0; i<vertices.Length; i++){
      if(vertices[i].label.Equals(source))
        start = i;
      if(vertices[i].label.Equals(target))
        eend = i;
    }
    AddEdgeDiGraph(start, eend);
  }
  public void ShowVertex(int v)
  {
    Console.Write(vertices[v].label + " ");
  }
  public void ShowAdjMatrix(){
    for(int i=0; i<NUM_VERTICES; i++){
      for(int j=0; j<NUM_VERTICES; j++)
        Console.Write("{0, 3}", adjMatrix[i, j]);
      Console.WriteLine();
    }
  }
  private int GetAdjUnvisitedVertex(int v)
  {
    for (int j = 0; j <= NUM_VERTICES - 1; j++)
      if ((adjMatrix[v, j] == 1) &&
 (vertices[j].wasVisited == false))
        return j;
    return -1;
  }

  public void DepthFirstSearch()
  {
    vertices[0].wasVisited = true;
    ShowVertex(0);
    Stack<int> gStack = new Stack<int>(); 
    gStack.Push(0);
    int v;

    while (gStack.Count > 0)
    {
      v = GetAdjUnvisitedVertex(gStack.Peek());
      if (v == -1)
        gStack.Pop();
      else
      {
        vertices[v].wasVisited = true;
        ShowVertex(v);
        gStack.Push(v);
      }
    }
    for (int j = 0; j <= NUM_VERTICES - 1; j++)
      vertices[j].wasVisited = false;
  }
  public void BreadthFirstSearch()
  {
    Queue<int> gQueue = new Queue<int>();
    vertices[0].wasVisited = true;
    ShowVertex(0);
    gQueue.Enqueue(0);
    int vert1, vert2;
    while (gQueue.Count > 0)
    {
      vert1 = gQueue.Dequeue();
      vert2 = GetAdjUnvisitedVertex(vert1);

      while (vert2 != -1)
      {
        vertices[vert2].wasVisited = true;
        ShowVertex(vert2);
        gQueue.Enqueue(vert2);
        vert2 = GetAdjUnvisitedVertex(vert1);
      }
    }
    for (int i = 0; i <= NUM_VERTICES - 1; i++)
      vertices[i].wasVisited = false;
  }
}
public class Program{
  public static void Main(string[] args)
  {
    Console.Clear();
    /*Graph g = new Graph(4);
    g.AddVertex("A");g.AddVertex("B");g.AddVertex("C");g.AddVertex("D");
    //g.AddEdge(0, 1);g.AddEdge(0, 2);g.AddEdge(0, 3);
    //g.AddEdge(1, 2);g.AddEdge(1, 3);
    //g.AddEdge(2, 3);
    g.AddEdge("A", "B"); g.AddEdge("A", "C"); g.AddEdge("A", "D");
    g.AddEdge("B", "C"); g.AddEdge("B", "D");
    g.AddEdge("C", "D");
    g.ShowAdjMatrix();*/
    
    /*Graph g2 = new Graph(3);
    g2.AddVertex("A");g2.AddVertex("B");g2.AddVertex("C");
    //g2.AddEdgeDiGraph(0, 1);g2.AddEdgeDiGraph(1, 2);
    //g2.AddEdgeDiGraph(2, 0);
    g2.AddEdgeDiGraph("A", "B"); g2.AddEdgeDiGraph("B", "C"); 
    g2.AddEdgeDiGraph("C", "A");
    g2.ShowAdjMatrix();*/

    Graph graph = new Graph(13);
    graph.AddVertex("A"); graph.AddVertex("B");//0 1
    graph.AddVertex("C"); graph.AddVertex("D");//2 3
    graph.AddVertex("E"); graph.AddVertex("F");//4 5
    graph.AddVertex("G"); graph.AddVertex("H");//6 7
    graph.AddVertex("I"); graph.AddVertex("J");//8 9
    graph.AddVertex("K"); graph.AddVertex("L");//10 11
    graph.AddVertex("M");//12
    graph.AddEdge("A", "B"); graph.AddEdge("A", "E");
    graph.AddEdge("A", "H"); graph.AddEdge("A", "K");
    graph.AddEdge("B", "C"); graph.AddEdge("C", "D");
    graph.AddEdge("E", "F"); graph.AddEdge("F", "G");
    graph.AddEdge("H", "I"); graph.AddEdge("I", "J");
    graph.AddEdge("K", "L"); graph.AddEdge("L", "M");
    //graph.AddEdge(0, 1); //graph.AddEdge(1, 0);
    //graph.AddEdge(0, 4); //graph.AddEdge(4, 0);
    //graph.AddEdge(0, 7); //graph.AddEdge(7, 0);
    //graph.AddEdge(0, 10); //graph.AddEdge(0, 10);
    //graph.AddEdge(1, 2); //graph.AddEdge(2, 1);
    //graph.AddEdge(2, 3); //graph.AddEdge(3, 2);
    //graph.AddEdge(4, 5); //graph.AddEdge(5, 4);
    //graph.AddEdge(5, 6); //graph.AddEdge(6, 5);
    //graph.AddEdge(7, 8); //graph.AddEdge(8, 7);
    //graph.AddEdge(8, 9); //graph.AddEdge(9, 8);
    //graph.AddEdge(10, 11); //graph.AddEdge(11, 10);
    //graph.AddEdge(11, 12); //graph.AddEdge(12, 11);
    Console.Write("DFS: ");
    graph.DepthFirstSearch();
    Console.Write("\nBFS: ");
    graph.BreadthFirstSearch();
    Console.ReadLine();
  }
}
//++++++++++++++++++++++++++++++++++++++++++++++
/*public class DistOriginal
{
  public int distance; public int parentVert;
  public DistOriginal(int pv, int d)
  {
    distance = d; parentVert = pv;
  }
}
public class Vertex
{
  public string label; public bool isInTree;
  public Vertex(string lab) { label = lab; isInTree = false; }
}
public class Graph
{
  private const int max_verts = 20;
  int infinity = 1000000; Vertex[] vertexList; int[,] adjMat;
  int nVerts; int nTree; DistOriginal[] sPath;
  int currentVert; int startToCurrent;
  public Graph()
  {
    vertexList = new Vertex[max_verts];
    adjMat = new int[max_verts, max_verts];
    nVerts = 0; nTree = 0;
    for (int j = 0; j <= max_verts - 1; j++)
      for (int k = 0; k <= max_verts - 1; k++)
        adjMat[j, k] = infinity;
    sPath = new DistOriginal[max_verts];
  }
  public void AddVertex(string lab)
  {
    vertexList[nVerts] = new Vertex(lab); nVerts++;
  }
  public void AddEdge(int start, int theEnd, int weight)
  {
    adjMat[start, theEnd] = weight;
  }
  public void Path()
  {
    int startTree = 0;
    vertexList[startTree].isInTree = true;
    nTree = 1;
    for (int j = 0; j <= nVerts; j++)
    {
      int tempDist = adjMat[startTree, j];
      sPath[j] = new DistOriginal(startTree, tempDist);
    }
    while (nTree < nVerts)
    {
      int indexMin = GetMin();
      int minDist = sPath[indexMin].distance;
      currentVert = indexMin;
      startToCurrent = sPath[indexMin].distance;
      vertexList[currentVert].isInTree = true;
      nTree++;
      AdjustShortPath();
    }
    DisplayPaths();
    nTree = 0;
    for (int j = 0; j <= nVerts - 1; j++)
      vertexList[j].isInTree = false;
  }
  public int GetMin()
  {
    int minDist = infinity;
    int indexMin = 0;
    for (int j = 1; j <= nVerts - 1; j++)
      if (!(vertexList[j].isInTree) && sPath[j].distance < minDist)
      {
        minDist = sPath[j].distance; indexMin = j;
      }
    return indexMin;
  }
  public void AdjustShortPath()
  {
    int column = 1;
    while (column < nVerts)
      if (vertexList[column].isInTree) column++;
      else
      {
        int currentToFring = adjMat[currentVert, column];
        int startToFringe = startToCurrent + currentToFring;
        int sPathDist = sPath[column].distance;
        if (startToFringe < sPathDist)
        {
          sPath[column].parentVert = currentVert;
          sPath[column].distance = startToFringe;
        }
        column++;
      }
  }
  public void DisplayPaths()
  {
    for (int j = 0; j <= nVerts - 1; j++)
    {
      Console.Write(vertexList[j].label + "=");
      if (sPath[j].distance == infinity) Console.Write("inf");
      else Console.Write(sPath[j].distance);
      string parent = vertexList[sPath[j].parentVert].label;
      Console.Write("(" + parent + ") ");
    }
  }
}
public class Program
{
  public static void Main()
  {
    Console.Clear();
    Graph theGraph = new Graph();
    theGraph.AddVertex("v0"); theGraph.AddVertex("v1");
    theGraph.AddVertex("v2"); theGraph.AddVertex("v3");
    theGraph.AddVertex("v4"); theGraph.AddVertex("v5");
    theGraph.AddEdge(0, 1, 2); theGraph.AddEdge(0, 2, 3);
    theGraph.AddEdge(1, 2, 2); theGraph.AddEdge(1, 3, 1);
    theGraph.AddEdge(1, 4, 3); theGraph.AddEdge(1, 5, 2);
    theGraph.AddEdge(2, 4, 1); theGraph.AddEdge(3, 4, 2);
    theGraph.AddEdge(3, 5, 1); theGraph.AddEdge(4, 5, 2);
    Console.WriteLine("Shortest paths:"); theGraph.Path();
    Console.ReadLine();
  }
}*/