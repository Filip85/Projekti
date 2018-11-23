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

void Smallest_Remaining_Time_First() {
	int i, j, z, k, n, br = 0, max = 0, min = 100, sum = 0, sum1 = 0, temp = 0, temp1 = 0, *Sum, temp2 = 0, temp3 = 0, min1 = 0;
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
		for (j = 0; j < n - 1; j++) {
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
		if (User[i].AT > max) {
			max = User[i].AT;
		}
	}


	for (i = 0; i < n; i++) {
		if (User[i].AT < min1) {
			min1 = User[i].AT;
		}
	}

	min = 100;

	for (i = 0; i < n; i++) {
		sum1 = sum1 + User[i].BT;
	}

	printf("\n\nVremenska os:\n\n");

	int temp4 = 0;

	min = 100;

	for (i = 0; i < n; i++) {
		if (i == 0) {
			temp = i;
			temp1 = User[i].pozicija;
			temp2 = User[i].BT;
			temp3 = User[i + 1].AT - User[temp].AT;
			printf("P%d\t", temp1);
			if (User[temp].BT < temp3) {
				sum = sum + User[temp].BT;
				User[temp].BT = 0;
				br = br + 1;
				User[temp].AT = -1;
			}
			else {
				sum = sum + (User[temp + 1].AT - User[temp].AT);
				User[temp].BT = User[temp].BT - (User[temp + 1].AT - User[temp].AT);
				br = br + 1;
			}
		}
		else if (i != 0 && User[i].AT > -1) {
			for (j = 0; j < n; j++) {
				if (User[j].BT <= min && User[j].AT <= sum && User[j].AT > -1) {
					min = User[j].BT;
					temp = j;
					temp1 = User[j].pozicija;
					temp2 = User[j].BT;
					temp3 = User[i + 1].AT - User[i].AT;
				}
			}
			for (k = 0; k < n; k++) {
				if (User[k].BT == temp2 && User[k].AT > -1 && User[k].BT <= sum && User[k].AT < User[temp].AT) {
					min = User[k].BT;
					temp1 = User[k].pozicija;
					temp2 = User[k].BT;
					temp3 = User[i + 1].AT - User[i].AT;
					temp = k;
				}
			}
		} 

		min = 100;

		if (i != 0 && User[temp].AT > -1) {
			printf("P%d\t", temp1);
			if (User[temp].BT <= temp3 && User[i].AT != max) {
				sum = sum + temp2;
				User[temp].BT = 0;
				br = br + 1;
				User[temp].AT = -1;
			}
			else if(User[temp].BT > temp3 && User[i].AT != max){
				sum = sum + (User[i + 1].AT - User[i].AT);
				User[temp].BT = User[temp].BT - (User[i + 1].AT - User[i].AT);
				br = br + 1;
			}
			else if(User[i].AT == max) {
				temp4 = sum;
				sum = sum + (User[i].AT - sum);
				User[temp].BT = User[temp].BT - (User[i].AT - temp4);
				br = br + 1;
			}
		}

		if (User[temp].BT == 0) {
			User[temp].AT = -1;
		}

		for (z = br - 1; z < br; z++) {
			Sum[z] = sum;
		}

		if (sum >= max) {
			break;
		}
	}

	temp2 = 100;

	while (sum < sum1) {
		for (i = 0; i < n; i++) {
			if (User[i].AT <= sum && User[i].AT > -1 && temp2 > User[i].BT && User[i].BT > 0) {
				temp1 = User[i].pozicija;
				temp = i;
				temp2 = User[i].BT;
			}
		}
		for (j = 0; j < n; j++) {
			if (User[j].AT <= sum && User[j].AT > -1) {
				if (temp2 == User[j].BT && User[j].AT < User[temp].AT) {
					temp2 = User[j].BT;
					temp1 = User[j].pozicija;
					temp = j;
				}
			}
		}

		User[temp].AT = -1;
		br = br + 1;
		printf("P%d\t", temp1);
		sum = sum + temp2;
		temp2 = 100;

		for (i = br - 1; i < br; i++) {
			Sum[i] = sum;
		}
	}

	printf("\n\n");

	if (min1 > 0) {

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

	for (i = 0; i < br; i++) {
		printf("%d\t", Sum[i]);
	}
	
	free(User);
	free(Sum);
}

int main() {

	Smallest_Remaining_Time_First();

	return 0;

}*/

