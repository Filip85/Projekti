/*#include<stdio.h>
#include<stdlib.h>
#define MAX 100

typedef struct korisnik {
	int AT;
	int BT;
	int pozicija;
} USER;

int front = -1;
int rear = -1;
int Q[MAX];

void Insert_Query(int element) {
	if (rear == MAX - 1) {
		printf("Red je pun");
		return;
	}
	if (front == -1) {
		front = 0;
	}

	rear = rear + 1;
	Q[rear] = element;
}

void Printf_Query(int *temp) {
	int i;

	if (front == -1 || rear == -1) {
		printf("Red je prazan");
		return;
	}

	for (i = front; i <= rear; i++) {
		printf("P%d\t", Q[i] + 1);
	}

	printf("\n");

	for (i = front; i <= rear; i++) {
		printf("%d\t", temp[i]);
	}
}


void swap(int *x, int *y) {
	int temp;

	temp = *x;
	*x = *y;
	*y = temp;
}

void Round_Robin() {
	int i, j, n, TQ, *Sum, sum = 0, sum1 = 0, sum2 = 0, br = 0, flag = 0, temp = 0, temp1 = 0, temp2 = 0, br1 = 0, br2 = 0, temp3 = 0, temp4 = 0, temp5 = 0;
	USER *User;

	printf("Unesite broj procesa:\n");
	scanf_s("%d", &n);

	printf("Unesite TQ:\n");
	scanf_s("%d", &TQ);

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
		sum1 = sum1 + User[i].BT;
	}

	if (User[0].AT > 0) {
		sum1 = sum1 + User[0].AT;
	}

	while (sum < sum1) {
		for (i = 0; i < n; i++) {
			br1++;
			temp = i;
			temp2 = i;
			temp3 = User[temp].pozicija; 
			temp4 = User[temp].pozicija;
			if (flag == 0) {
				Insert_Query(temp3); 
				br2++;
				br = br + 1;
				if (i == 0 && User[0].AT > 0) {
					temp5 = User[0].AT;
					User[0].AT = -1;
				}
				else {
					User[temp].AT = -1;
				}
				flag = 1;
			}

			if (flag == 1) {
				flag = 0;
				if (User[temp].BT >= TQ && flag == 0 && User[temp].BT > 0) {
					if (i == 0 && flag == 0 && temp5 > 0) {
						sum = sum + TQ + temp5;
						br1++;
						Sum[0] = sum;
						User[0].BT = User[0].BT - TQ;
						flag = 1;
					}
					else if(flag == 0){
						sum = sum + TQ;
						br1++;
						Sum[i] = sum;
						User[temp].BT = User[temp].BT - TQ;
						flag = 1;
					}
				}
				else if (User[temp].BT < TQ && flag == 0 && User[temp].BT > 0) {
					if (i == 0 && temp5 > 0 && flag == 0) {
						sum = sum + temp5 + TQ;
						br1++;
						Sum[0] = sum;
						User[0].BT = 0;
						flag = 1;
					}
					else if(flag == 0){
						sum = sum + User[temp].BT;
						br1++;
						Sum[i] = sum;
						User[temp].BT = 0;
						flag = 1;
					}
				}
				for (j = 0; j < n; j++) {
					if (sum >= User[j].AT && User[j].AT > -1) {
						temp = j;
						temp3 = User[temp].pozicija;     
						Insert_Query(temp3);
						br2++;
						User[temp].AT = -1;
						br = br + 1;
						if (br == n) {
							break;
						}
					}
				}
			}

			flag = 0;
			if (User[temp2].BT >= TQ && flag == 0 && User[temp2].BT > 0) {
				Insert_Query(temp4);
				br2++;
				temp3 = User[temp2].pozicija;         
			}
			else if (User[temp2].BT < TQ && flag == 0 && User[temp2].BT > 0) {
				Insert_Query(temp4);
				br2++;
				temp3 = User[temp2].pozicija;
			}

			flag = 1;

			if (br == n) {
				break;
			}
		}
		
		if (br == n) {
			break;
		}
	}


	for (i = 1; i < n; i++) {
		for (j = 0; j < n - 1; j++) {
			if (User[j].pozicija > User[j + 1].pozicija) {
				swap(&User[j].pozicija, &User[j + 1].pozicija);
				swap(&User[j].AT, &User[j + 1].AT);
				swap(&User[j].BT, &User[j + 1].BT);
			}
		}
	}

	flag = 0;

	while (sum < sum1) {
		for (i = temp2 + 1; i < 100; i++) {
			temp = i;
			temp1 = Q[temp];
			flag = 1;

			if (User[temp1 - 1].BT > TQ && User[temp1 - 1].BT > 0 && flag == 1) {
				Insert_Query(Q[i]);
				br2++;
				printf("P%d\t", temp1);
				sum = sum + TQ;
				br1++;
				Sum[i] = sum;
				User[temp1 - 1].BT = User[temp1 - 1].BT - TQ;
				flag = 0;
			}
			if (User[temp1 - 1].BT == TQ && User[temp1 - 1].BT > 0 && flag == 1) {
				sum = sum + TQ;
				Sum[i] = sum;
				br1++;
				User[temp1 - 1].BT = User[temp1 - 1].BT - TQ;
				flag = 0;
			}
			if (User[temp1 - 1].BT < TQ && User[temp1 - 1].BT > 0 && flag == 1) {
				sum = sum + User[temp1 - 1].BT;
				br1++;
				Sum[i] = sum;
				User[temp1 - 1].BT = User[temp1 - 1].BT - User[temp1 - 1].BT;
				flag = 0;
			}

			if (sum >= sum1) {
				break;
			}
		}
		if (sum >= sum1) {
			break;
		}
	}

	printf("\n\n");

	if (User[0].AT > 0) {
		for (i = 0; i < n; i++) {
			Sum[i] = Sum[i] + User[0].AT;
		}
	}

	printf("\n\n");

	printf("Vremenska os:\n\n");

	for (i = 0; i < br2; i++) {
		printf("P%d\t", Q[i]);
	}

	printf("\n\n");

	for (i = 0; i < br2; i++) {
		printf("%d\t", Sum[i]);
	}

	free(User);
	free(Sum);
}

int main() {

	Round_Robin();

	return 0;
}*/