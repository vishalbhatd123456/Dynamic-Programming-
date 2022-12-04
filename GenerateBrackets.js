

function generateBrackets(output,n,open,close,i){
  //base case
  if(i == 2*n){
    console.log(output);
    return;
  }
  
  //apply an opening bracket
  if(open < n){
    //this will be a mistake - output+='('
    generateBrackets(output+'(',n,open+1,close,i+1);
  }
  
  //apply a closing bracket
  if(close<open){
    generateBrackets(output+')',n,open,close+1,i+1);
  }
}
var output = "";
var n,open="",close="",i=0;
generateBrackets(output,n,open,close,i);
