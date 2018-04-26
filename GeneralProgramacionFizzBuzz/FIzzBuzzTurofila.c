
// Author: @FisionBoy03

#include <iostream>
#include <string.h>
#include <stdio.h>
using namespace std;


main(){
	
	for(int i = 0; i < 100; i++){
		if(i % 3 == 0 && i % 5 == 0){
			printf("FizzBuzz\n");
		}else if(i % 3 == 0){
			printf("Fizz\n");
		}else if(i % 5 == 0){
			printf("Buzz\n");
		}else{
			printf("%d\n", i);
		}
	}
}
