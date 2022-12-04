using System;
using System.Collections;


int solveNQueen(int n, int[][] board, int i){
  //base case
  if(i == n){
    //printBoard(n,board)
    return true;
  }
  
  //recursive case
  
  //try to place queen in every row
  int ways = 0;
  
  for(int j = 0; j < n;j++){
    if(canPlace(board,n,i,j)){
    board[i][j] = 1;
    bool success = solveNQueen(n,board,i+1);
    if(success){
    ways+=1;
       }
    }
    board[i][j] = 0;
  }
  return ways;
}

public bool canPlace(int[][] board, int n,int x, int y){
  //column
  
  for(int k = 0;k < y;k++){
  if(board[k][y] == 1) return false;
  }
  
  //left diagnol
  int i = x;
  int j = y;
  
  while(i>=0 && j>=0){
  if(board[i][j] == 1)
  return false;
  i--;
  j--;
  }
  
  //right diagnol
  i = x;
  j = y;
  while(i>=0 && j < n){
  if(board[i][j] == 1){
  return 1;
  }
  }
  
}





public static void Main(string[] args){
int [][] board;
int n;
Console.WriteLine("Enter the size of the chess board:");
n = Console.ReadLine();
Console.WriteLine("The count of the ways that the queens that can be placed is:",solveNQueen(n,board,0));
Console.ReadLine();
}
