/*#include<stdio.h>
#include<stdlib.h>

int *CT;                       
int *TAT;                        
int *WT;                         
int Avg_TAT = 0;
int Avg_WT = 0;
int MIN = 0;

int Min(int *BT, int *AT, int n) {
	int min, i;

	min = 0;

	for (i = 0; i < n; i++) {
		if (AT[i] < min){
			min = i;
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

void Bubble_Sort(int *BT, int *AT, int *PNO, int n) {
	int i, j;

    MIN = Min(BT, AT, n);

	printf("%d\n", MIN);

	if (MIN == 0) {
		for (i = 1; i < n - 1; i++) {
			for (j = 1; j < n - i; j++) {
				if (BT[j] > BT[j + 1]) {
					swap(&PNO[j], &PNO[j + 1]);
					swap(&AT[j], &AT[j + 1]);
					swap(&BT[j], &BT[j + 1]);
				}
			}
		}
	}
	else {
		for (i = 0; i < n - 1; i++) {
			for (j = 0; j < n - i; j++) {
				if (BT[j] > BT[j + 1]) {
					swap(&PNO[j], &PNO[j + 1]);
					swap(&AT[j], &AT[j + 1]);
					swap(&BT[j], &BT[j + 1]);
				}
			}
		}
	}
}

void Bubble_Sort_CT(int *CT, int *PNO, int n) {
	int i, j;

	for (i = 0; i < n - 1; i++) {
		for (j = 0; j < n - i; j++) {
			if (CT[j] > CT[j + 1]) {
				swap(&PNO[j], &PNO[j + 1]);
				swap(&CT[j], &CT[j + 1]);
			}
		}
	}
}

void Shortest_Process_Next(int *AT, int *BT, int *PNO, int n) {
	int i, sum = 0;

	CT = (int*)malloc(n * sizeof(int));
	TAT = (int*)malloc(n * sizeof(int));
	WT = (int*)malloc(n * sizeof(int));

	Bubble_Sort(BT , AT, PNO, n);

	for (i = 0; i < n; i++) {
		if (i == 0) {
			CT[i] = AT[i] + BT[i];
		}
		else if (i != 0) {
			if (CT[i - 1] > AT[i]) {
				CT[i] = CT[i - 1] + BT[i];
			}
			else {
				CT[i] = AT[i] + BT[i];
			}
		}
	}

	for (i = 0; i < n; i++) {
		TAT[i] = CT[i] - AT[i];
	}

	for (i = 0; i < n; i++) {
		WT[i] = TAT[i] - BT[i];
	}

}

int main() {
	int *AT;
	int *BT;
	int *PNO;
	int n;
	int i;

	printf("Unesite broj procesa:\n");
	scanf_s("%d", &n);

	AT = (int*)malloc(n * sizeof(int));
	BT = (int*)malloc(n * sizeof(int));
	PNO = (int*)malloc(n * sizeof(int));

	printf("Unesite vrijeme pojavljivanja procesa:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &AT[i]);
	}

	printf("Unesite vrijeme trajanja procesa:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &BT[i]);
	}

	for (i = 0; i < n; i++) {
		PNO[i] = i + 1;
	}

	Shortest_Process_Next(AT, BT, PNO, n);

	printf("PNO\tAT\tBT\tCT\tTOT\tWT\n");

	for (i = 0; i < n; i++) {
		printf("%d\t%d\t%d\t%d\t%d\t%d\n", PNO[i], AT[i], BT[i], CT[i], TAT[i], WT[i]);
	}

	printf("\n");

	for (i = 0; i < n; i++) {
		Avg_TAT = Avg_TAT + TAT[i];
	}
	Avg_TAT = Avg_TAT / n;
	printf("%d\n", Avg_TAT);

	for (i = 0; i < n; i++) {
		Avg_WT = Avg_WT + WT[i];
	}
	Avg_WT = Avg_WT / n;
	printf("%d\n", Avg_WT);

	free(AT);
	free(BT);
	free(CT);
	free(TAT);
	free(WT);

	return 0;
}*/