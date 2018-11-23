/*#include<stdio.h>
#include<stdlib.h>

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

void Shortes_Job_First() {
	int i, j, *Sum, sum = 0, sum1 = 0, min = 0, min1 = -1, temp = 0, temp1 = 0, br = 0, temp2 = 0, temp3, n;
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

	for (i = 1; i < n; i++) {
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

	for (i = 0; i < n; i++) {
		sum1 = sum1 + User[i].BT;
	}

	min = 100;
	min1 = User[0].BT;

	for (i = 0; i < n; i++) {
		if (min > User[0].AT) {
			min = User[i].AT;
			temp = User[i].pozicija;
			temp1 = User[i].BT;

		}
	}

	printf("%d\t%d\t%d\n\n", min, temp, temp1);

	while (sum < sum1) {
		if (sum == 0) {

			temp2 = temp;

			User[0].AT = -1;

			temp1 = User[0].BT;

			sum = sum + temp1;

			br = br + 1;

			printf("P%d\t", temp);

			for (i = 0; i < br; i++) {
				Sum[i] = sum;
			}

			temp1 = 100;
		}
		else if (sum != 0) {
			for (i = 0; i < n; i++) {
				if (User[i].AT <= sum && User[i].AT > -1 && temp1 > User[i].BT) {
					temp = User[i].pozicija;
					temp2 = i;
					temp1 = User[i].BT;
				}
			}
			for (j = 0; j < n; j++) {
				if (User[j].AT <= sum && User[j].AT > -1) {
					if (temp1 == User[j].BT && User[j].AT < User[temp2].AT) {
						temp1 = User[j].BT;
						temp = User[j].pozicija;
						temp2 = j;
					}
				}
			}

			User[temp2].AT = -1;
			br = br + 1;
			printf("P%d\t", temp);
			sum = sum + temp1;
			temp1 = 100;

			for (i = br - 1; i < br; i++) {
				Sum[i] = sum;
			}
		}
	}

	if (min > 0) {

		for (i = 0; i < n; i++) {
			if (i == 0) {
				Sum[i] = Sum[i] + min;
			}
			else {
				Sum[i] = Sum[i] + 1;
			}
		}
	}

	printf("\n\n");

	for (i = 0; i < n; i++) {
		printf("%d\t", Sum[i]);
	}

	free(User);
	free(Sum);
}

int main() {

	Shortes_Job_First();

	return 0;

}*/