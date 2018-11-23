#include <stdio.h>
#include<stdlib.h>
#define N 100

int *Array;
int n;                 

typedef struct korisnik{
	int broj_procesa;
	int procesi[100];
	int pozicija;
} USER;

void Fair_Share_Scheduling() {
	int i, j, ASCII = 64, z, k = 0, max_p, pozicijaa;
	float temp, *CPU_percentage;
	USER *User;

	printf("Unesite broj korisnika:\n");
	scanf_s("%d", &n);

	User = (USER*)malloc(n * sizeof(USER));
	CPU_percentage = (float*)malloc(n * sizeof(float));

	printf("Unesite broj procesa svakog korisnika:\n");

	for (i = 0; i < n; i++) {
		scanf_s("%d", &User[i].broj_procesa);
	}

	printf("\nUnesite procese svakog korisnika:\n");

	for (i = 0; i < n; i++) {
		for (j = 0; j < User[i].broj_procesa; j++) {
			scanf_s("%d", &User[i].procesi[j]);
		}
	}


	temp = 100 / n;

	printf("\n");

	for (i = 0; i < n; i++) {
		for (j = 0; j < n; j++)
			if (User[i].broj_procesa > 1) {
				CPU_percentage[i] = temp / (float)User[i].broj_procesa;
			}
			else {
				CPU_percentage[i] = temp;
			}
	}

	for (i = 0; i < n; i++) {
		printf("P%d:\t", i + 1);
		ASCII = ASCII + 1;
		for (j = 0; j < User[i].broj_procesa; j++) {
			printf("%c%d\t", ASCII, User[i].procesi[j]);
		}
		printf("\n\n");
	}

	printf("\nDistribution of Cpu:\n");

	for (i = 0; i < n; i++) {
		printf("P%d\t: %f\n", i + 1, CPU_percentage[i]);
	}

	ASCII = 64;

	for (i = 0; i < n; i++) {
		User[i].pozicija = 0;
	}

	int max = 0;

	for (i = 0; i <= User[i].broj_procesa; i++) {
		if (max < User[i].broj_procesa) {
			max = User[i].broj_procesa;
		}
	}

	pozicijaa = 0;

	printf("\n\n");
	printf("Vremenska os:\n\n");

	for (i = 0; i < max; i++) {
		ASCII = 64;
		for (j = 0; j < n; j++) {
			if (User[j].pozicija >= User[j].broj_procesa) {
				ASCII = ASCII + 1;
				User[j].pozicija = 0;
				pozicijaa = User[j].pozicija;
				printf("%c%d\t", ASCII, User[j].procesi[pozicijaa]);
				User[j].pozicija = User[j].pozicija + 1;
			}
			else {
				ASCII = ASCII + 1;
				pozicijaa = User[j].pozicija;
				printf("%c%d\t", ASCII, User[j].procesi[pozicijaa]);
				User[j].pozicija = User[j].pozicija + 1;
			}
		}
	}

	free(User);
	free(CPU_percentage);
}

int main() {

	Fair_Share_Scheduling();

	return 0;

}