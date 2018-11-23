/*#include<stdio.h>
#include<stdlib.h>
#define MAX 100

typedef struct korisnik {
	int AT;
	int BT;
	int pozicija;
} USER;

void swap(int *x, int *y) {
	int temp;

	temp = *x;
	*x = *y;
	*y = temp;
}

void First_Come_First_Served() {
	int i, j, *Sum, sum = 0, n;
	USER *User;

	printf("Unesite broj procesa:\n");
	scanf_s("%d", &n);

	User = (USER*)malloc(n * sizeof(USER));

	Sum = (int*)malloc(n * sizeof(int));

	printf("Unesite vrijeme pojavljivanja procesa:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &User[i].AT);
	}

	printf("Unesite vrijeme trajanja procesa:\n");
	for (i = 0; i < n; i++) {
		scanf_s("%d", &User[i].BT);
	}

	for (i = 0; i < n; i++) {
		User[i].pozicija = i + 1;
	}

	printf("\n\nPNO\tAT\tBT\t\n");

	for (i = 0; i < n; i++) {
		printf("P%d\t%d\t%d\t\n", User[i].pozicija, User[i].AT, User[i].BT);
	}

	for (i = 1; i < n - 1; i++) {
		for (j = 0; j < n - i; j++) {
			if (User[j].AT > User[j + 1].AT) {
				swap(&User[j].pozicija, &User[j + 1].pozicija);
				swap(&User[j].AT, &User[j + 1].AT);
				swap(&User[j].BT, &User[j + 1].BT);
			}
		}
	}

	printf("\n\nPNO\tAT\tBT\t\n");

	for (i = 0; i < n; i++) {
		printf("P%d\t%d\t%d\t\n", User[i].pozicija, User[i].AT, User[i].BT);
	}

	printf("\n\n");

	for (i = 0; i < n; i++) {
		printf("P%d\t", User[i].pozicija);
		sum = sum + User[i].BT;
		Sum[i] = sum;
	}

	printf("\n\n");

	for (i = 0; i < n; i++) {
		printf("%d\t", Sum[i]);
	}

	free(User);
	free(Sum);

}


int main() {

	First_Come_First_Served();

	return 0;
	
}*/

