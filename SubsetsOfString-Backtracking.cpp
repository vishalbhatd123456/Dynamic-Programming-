#include<iostram.h>

void findSubsets(char *input, char *output, int i, int j){
  // the i pointer will point to the input string, the j will point over the output, we build the output progressively
  // the reason this is backtracking is because we iterate over all possible subsets, and takes exponential time
  
  //base case
  if(input[i] == '\0'){
    //we have reached the leaf node of the recursion tree
    output[j] = '\0';
    cout<<output<<endl;
    return;
  }
  
  
  //recursive case
  
  //case 1 : include the letter in subset
  output[j] = input[i];
  findSubsets(input,output,i+1,j+1);
  
  //case 2 : exclude the letter in subset
  findSubsets(input,output,i+1,j);
}

