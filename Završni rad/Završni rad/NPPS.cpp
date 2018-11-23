/*#include<stdio.h>
#include<stdlib.h>
#include "SPN.cpp"
#define MAX 100

int *CT;                      
int *TAT;                     
int *WT;                       
int MIN;

int Min(int *BT, int *AT, int *PR, int n, int sum, int *temp) {
	int min, i, j;

	min = PR[0];

	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++) {
			if (PR[i] < min && sum >= AT[j] && j != temp[j]) {
				min = PR[i];
				printf("P%d", j);
				sum = sum + BT[i];
			}
		}
	}

	return min;
}

void swap(int *x, int *y) {
	int temp;

	temp = *x;
	*x = *y;
	*y = temp;
}

void Bubble_Sort(int *BT, int *AT, int *PR, int n) {
	int i, j;

	if (MIN == 0) {
		for (i = 1; i < n - 1; i++) {
			for (j = 1; j < n - i; j++) {
				if (PR[j] > PR[j + 1]) {
					swap(&PR[j], &PR[j + 1]);
					swap(&AT[j], &AT[j + 1]);
					swap(&BT[j], &BT[j + 1]);
				}
			}
		}
	}
	else if(MIN != 0) {
		for (i = 1; i < n - 1; i++) {
			for (j = 0; j < n - i; j++) {
				if (PR[j] > PR[j + 1]) {
					swap(&PR[j], &PR[j + 1]);
					swap(&AT[j], &AT[j + 1]);
					swap(&BT[j], &BT[j + 1]);
				}
			}
		}
	}
}

void Non_Preemptive_Priority_Scheduling(int *AT, int *BT, int *PR, int n) {
	int i, j, sum = 0, max, min, temp1 = 0, sum1 = 0, temp2, *temp, *Sum, br = 0;

	temp = (int*)malloc(n * sizeof(int));
	Sum = (int*)malloc(n * sizeof(int));
	
	printf("\n");

	printf("PNO\tPR\tAT\tBT\n");

	for (i = 0; i < n; i++) {
		printf("%d\t%d\t%d\t%d\n", i + 1, PR[i], AT[i], BT[i]);
	}

	max = 100; 

	for (i = 0; i < n; i++) {
		sum1 = sum1 + BT[i];
	}

	printf("%d\n", sum1);

	min = AT[0];
	temp2 = BT[0];

	for (i = 0; i < n; i++) {
		if (AT[i] <= min) {
			min = AT[i];
			temp1 = i;
			temp2 = BT[i];
		}
	}

	printf("%d\n%d\n", temp2, temp1);

	printf("%d\n\n", min);

	temp[0] = temp1;
	max = 0;

	for (i = 0; i < n; i++) {
		if (PR[i] > max) {
			max = PR[i];
		}
	}

	printf("%d\n\n", max);

	sum = 0;

	max = -1;

	while (sum < sum1) {
		if (sum == 0) {
			printf("P%d\t", temp1 + 1);
			AT[temp1] = -1;
			sum = sum + temp2;
			
			br = br + 1;

			for (i = 0; i < br; i++) {
				Sum[i] = sum;
			}
		}
		else if(sum != 0){
			for (i = 0; i < n; i++) {
				if (PR[i] > -1 && AT[i] <= sum && AT[i] != -1 && max <= PR[i]) {
					max = PR[i];
					temp1 = i;
					temp2 = BT[i];
				}
			}
			for (j = 0; j < n; j++) {
				if (AT[j] <= sum && AT[j] > -1) {
					if (max == PR[j] && AT[j] < AT[temp1]) {
						temp1 = j;
						max = PR[j];
						temp2 = BT[j];
					}
				}
			}
			br = br + 1;
			max = -1;
			AT[temp1] = -1;
			sum = sum + temp2;
			printf("P%d\t", temp1 + 1);

			for (i = br - 1; i < br; i++) {
				Sum[i] = sum;
			}
		}
	}

	printf("\n\n");

	for (i = 0; i < br; i++) {
		printf("%d\t", Sum[i]);
	}

	free(temp);
	free(Sum);

}

int main() {
	int *AT;
	int *BT;
	int *PR;
	int n;
	int i;

	printf("Unesite broj procesa:\n");
	scanf_s("%d", &n);

	AT = (int*)malloc(n * sizeof(int));
	BT = (int*)malloc(n * sizeof(int));
	PR = (int*)malloc(n * sizeof(int));

	printf("Unesite vrijeme pojavljivanja procesa:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &AT[i]);
	}

	printf("Unesite vrijeme trajanja procesa:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &BT[i]);
	}

	printf("Unesite prioritete:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &PR[i]);
	}

	printf("Vremenska os:\n");

	Non_Preemptive_Priority_Scheduling(AT, BT, PR, n);

	free(AT);
	free(BT);
	free(PR);

	return 0;

}*/