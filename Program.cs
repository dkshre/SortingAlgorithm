using System;

namespace SortingAlgorithm
{

    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new [] {7,2,1,6,8,5,3,4};
            Program.QuickSort(arr,0, arr.Length-1);

            //Program.SelectionSort(arr,arr.Length);
            Program.PrintArray(arr, "Quick Sort");

        }

        static void QuickSort(int[] arr, int start, int end){
            if(start>= end) return;
            int pIndex = Program.Partition(arr, start, end);
            Program.QuickSort(arr, start, pIndex-1);
            Program.QuickSort(arr, pIndex+1, end);

        }

        //Partition for Quick sort
        static int  Partition(int[] arr, int start, int end){
          int pIndex = start;
          int pivot = arr[end];
          for(int i = start;i <= end-1; i++){
              if(arr[i] <= arr[end]){
                  Program.Swap(ref arr[pIndex],ref arr[i]);
                  pIndex = pIndex +1;
              }
          }
          Program.Swap(ref arr[pIndex],ref arr[end]);
          return pIndex;
        }
        static void PrintArray(int[] arr, string comment){
            Console.WriteLine(comment);
                foreach(int v in arr){
                    Console.Write(v + " ");
                }
            Console.WriteLine();
        }

        static void MergeSort(int[] arr) {
            int n = arr.Length;
            if(n < 2)
                return;
            int mid = n/2;

            int[] left = new int[mid];
            int[] right = new int[n-mid];

            for(int i=0; i<mid; i++){
                left[i] = arr[i];
            }

            for(int i = mid; i < n; i++){
                right[i-mid] = arr[i];
            }

            Program.MergeSort(left);
            Program.MergeSort(right);
            Program.MergeTwoArray(left, right,arr);
        }
        static void MergeTwoArray(int[] left, int[] right, int[] arr){
            //merge two Array
            int i=0; int j = 0; int k = 0;
            while(i < left.Length && j < right.Length){
                if(left[i]<right[j]){
                    arr[k] = left[i];
                    i = i + 1;
                    k = k + 1;
                }
                else{
                    arr[k] = right[j];
                    j = j + 1;
                    k = k + 1; 
                }
            }

            while(i< left.Length){
                arr[k] = left[i];
                i= i + 1;
                k = k + 1;
            }
            while(j < right.Length){
                arr[k] = right[j];
                j = j + 1;
                k = k + 1;
            }
        }


        static void InsertionSort(int [] a, int n){
            for(int i=1; i < n; i++){
                int value = a[i];
                int hole = i;
                while(hole >0 && a[hole-1]> value){
                    a[hole] = a[hole -1];
                    hole = hole -1;
                }
                a[hole] = value;
            }
        }

        static void SelectionSortRecursive(int[] a, int n, int i){
            int iMin = i;
                for(int j = i+1; j< n; j++){
                    if(a[j]< a[iMin]){
                        iMin = j;
                    }
            }
            int temp = a[i];
            a[i] = a[iMin];
            a[iMin] = temp; 

            if(i<n-1){
                SelectionSortRecursive(a,n, i+1);
            }
        }

        static void SelectionSort(int[] a, int n){
          for(int i = 0 ; i < n-1; i++){
              int iMin = i;
              for(int j = i+1; j< n; j++){
                  if(a[j]< a[iMin]){
                      iMin = j;
                  }
              }            
            Program.Swap(ref a[i], ref a[iMin]);   
          }
        }

        static void BubbleSortRecursive(int[] a, int n){
            for(int i=0 ; i < a.Length-1; i++){                    
                if(a[i]>a[i+1]){
                    int temp = a[i];
                    a[i] = a[i+1];
                    a[i+1] = temp;                        
                }                
            }
            if(n-1 > 1){
                BubbleSortRecursive(a,n-1);
            }
        }

        static void BubbleSort(int[]a ){
            int totalPass = 0;
            bool flag = true;
            for(int k = 0; k<a.Length-1 ; k++){
                for(int i=0 ; i < a.Length-1-k; i++){
                    totalPass = totalPass +1;
                        if(a[i]>a[i+1]){
                            Program.Swap(ref a[i], ref a[i+1]);
                           // int temp = a[i];
                            //a[i] = a[i+1];
                           // a[i+1] = temp;
                            flag = false;
                        }
                
                }
                if(flag){
                    break;
                }
            }

            Console.WriteLine(String.Format("Total pass {0}", totalPass));
        }

        static int LargestValueRecursive(int[] a, int index){

            if(index > 0){
                return Math.Max (a[index], LargestValueRecursive(a,index-1));
            }
            else{
                return a[0];
            }
        }

       static void Swap(ref int a, ref int b){
        int temp = a;
         a = b;
         b = temp;

       }

        static void PassingArray(ref int[] arr){
             int [] vr = new [] {40, 20, 50};
            //arr[0] = 100;
            arr = vr;
        }

        static void FindLargestValue( int []arr){
              int currBig = arr[0];
              int currIndex = 0;
               for(int i=0; i<arr.Length; i++){
                //   if(currValue<arr[i]){
                //     currValue = arr[i];
                //     currIndex = i;
                //   } 

                  if(arr[i] < currBig){
                  }
                  else{
                     currBig = arr[i];
                     currIndex = i;
                  }
               }
                Console.WriteLine(currBig  + " Index " + currIndex);

        }
        static void FindLargestValue1( int []arr){
              int currValue = arr[0];
               foreach(int v in arr){
                 if(v<currValue){

                 }
                 else{
                     currValue = v;
                 }
               }                
               
                Console.WriteLine(currValue);

        }

    }
}
