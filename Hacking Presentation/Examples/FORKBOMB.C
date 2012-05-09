#include<stdio.h>
#include<process.h>
#include<malloc.h>
#include<string.h>

void main()
{
   int pid=getpid();                       //Retrieved the current Process id
   char newstr[80];
   char *str=null;
   char *buffer=null;                     //To avoid Dangling Pointer Creation
   char ch;
   int i;

   buffer=(char *)malloc(sizeof(int));    //Dynamically allocated  2 bytes for pid
   str=(char *)malloc(20 * sizeof(char)); //Dynamically allocated space for CMD command
   str="taskill /PID";
   itoa(pid,buffer,10);
   newstr=strcat(str,buffer);


   for(i=0;i<3;i++)
   {
      fork();                        //Created copy of existing process from this point
      printf("Enter 'y' or 'Y' to kill the process\n");
      ch=getchar();
      if((ch=='y')||(ch=='Y'))
      {
	 system(newstr);

      }



   }

}