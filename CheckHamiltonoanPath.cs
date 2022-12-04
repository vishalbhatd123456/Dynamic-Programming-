using System;
using System.Collections;

int vis[] = new int[n];
List<int> graph = new ArrayList<>();

public bool paths(int curr, int count,int n){
  bool hamiltonian_path = false;
  //base case
  if(count == n){
    hamiltonian_path = true;
    return hamiltonian_path;
  }
  
  
  vis[curr] = 1; //we visit the current node and mark in the visited array
  
  foreach(int nextNode in graph[curr]){
    if(!vis[x]) paths(nextNode,count+1,n);
  }
  
 //unvisit the node
 vis[curr] = 0;

}

public static void Main(){
  graph.Add(....);
  if(paths){
    // Hamiltonian cylce done
    }
    
}
