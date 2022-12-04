
//import packages
package main;
import (
  "fmt"
)
func solveNQueen(n int, board[][20] var, i int){
  //base case
  if i == n{
    printBoard(n,board);
    return true;
  }
  //recursive case
  //try to place queen in every row
  //i :== row, j :== column
  for j:=0;j<n;j++{
    //whether the current i,j is safe or NOT
    if canPlace(board,n,i,j){
      board[i][j] = 1;
      bool success = solveNQueen(n,board,i+1);
      if success{
        fmt.Println("NQueens Algorithm Found a Valid Configuration!");
        return true;
      }
      //the current configuration cannot be valid, then mark board as false
      board[i][j] = 0;
    }
  }
  return false; // parent configuration is incorrect;
}

func canPlace(board[][] var, n int,i=x int,y int){
  
  //check column
  for k:=0;k<x;k++{
    if(board[k][y] == 1)
    return false;
  }
  
  //check left diagnol
  var i int;
  i = x;
  var j int;
  j = y;
  while i>=0 && j>=0:{
    if board[i][j] == 1 {
      return false;
    }
    i--;
    j--;
  }
  
  //check right diagnol
  i = x;
  j = y;
  while i>=0 && j<n{
    if board[i][j] == 1 {
      return false;
    }
    i--;
    j++;
  }
}


func printBoard(n int, board[][20] var){
  for i:=0;i<n;i++{
    for j:=0;j<n;j++{
      fmt.Println(board[i][j]+" ");
    }
    fmt.Println();
  }
}


func init(){
  fmt.Println("This is an implicit call, no one will reference this function");
}


//main function
func main(){
  fmt.Println("Starting NQueens problem:");
  var board[20][20]int;
  var n int
    _, err := fmt.Scanf("%d", &n);
  solveNQueen(n,board,0);
  return 0;
}
