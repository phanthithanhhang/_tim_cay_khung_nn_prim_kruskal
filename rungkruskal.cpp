/*
Thuật toán Kruskal
1. Sắp xếp các cạnh theo độ dài từ nhỏ đến lớn
2. Một cạnh sẽ được đưa vào cây nếu nó không tạo thành chu trình
3. Lặp lại bước 2 cho đến khi xây dựng được cây có n-1 cạnh
*/

#include <stdio.h>
#define size 30
#define duongVC 3.40282e+38 //So float 32 bit lon nhat

typedef struct 
{
	float do_dai;
	int dau, cuoi;
}canh;

void read_file(char file_name[], canh a[], int *n)
{
	int i, j, t;
	float temp;
	FILE *f; //Khai bao f la con tro file
	f = fopen(file_name, "r");
	if (f == NULL)
	{
		printf("Loi mo file!!!");
		return;
	}
	fscanf(f, "%d", n); //Đọc số đỉnh của đồ thị(so dau tien)
	
	int k = 0;
	for(i=0; i<*n; i++)
	{
		for(j=i; j<*n; j++) //doc nua tren cua ma tran
			if (i==j)	
				for(t=0; t<=j; t++)	 fscanf(f, "%f", &temp);
			else
			{
				fscanf(f, "%f", &a[k].do_dai);
				a[k].dau=i;
				a[k].cuoi=j;
				k++;
			}			
	}
	fclose(f);
}

void in_ds_canh(canh a[], int m, int la_PA)
{
	int i;
	float tong = 0;
	for(i=0; i<m; i++)
	{
		if(a[i].do_dai < duongVC)
			printf("%3d (%d,%d) = %5.2f\n", i+1, a[i].dau+1, a[i].cuoi+1, a[i].do_dai);
		else
			printf("%3d (%d,%d) = %5c\n", i+1, a[i].dau+1, a[i].cuoi+1, 236); //236 là mã ASCCII của ký hiệu vô cùng lớn 
			if(la_PA)
				tong += a[i].do_dai;
	}
	if(la_PA)
		printf("Tong do dai cac canh = %8.2f\n", tong);
}

void swap(canh *x, canh*y)
{
	canh temp = *x;
	*x = *y;
	*y = temp;
}

//Sắp xếp
void bubble_sort(canh a[], int m)
{
	int i, j;
	for(i=0; i<m-1; i++)
		for(j=m-1; j>i; j--)
			if(a[j].do_dai < a[j-1].do_dai)
				swap(&a[j], &a[j-1]);
}

//Khởi tạo rừng cây
//Mỗi cây có 1 nút là các đỉnh của đồ thị
void init_forest(int parent[], int n)
{
	int i;
	for(i=0; i<n; i++)
	{
		parent[i]=i;
	}
}

//Tìm nút gốc của nút u trong cây parent
int find_root(int parent[], int u)
{
	while(u != parent[u])
		u = parent[u];
	return u;
}

void kruskal(canh dsc[], int n, canh T[])
{
	int i, j=0, r_dau, r_cuoi;
	int parent[n];
	init_forest(parent, n); //Khởi tạo rừng ban đầu
	for(i=0; j<n-1 && dsc[i].do_dai<duongVC; i++)
	{
		r_dau = find_root(parent, dsc[i].dau);
		r_cuoi = find_root(parent, dsc[i].cuoi);
		if(r_dau != r_cuoi) //Nếu không tạo thành chu trình
		{
			T[j] = dsc[i];
			parent[r_cuoi] = r_dau; //Hợp nhất 2 cây với nhau
			j++;
		}
	}
}

int main()
{
	canh ds_canh[size]; //danh sách các cạnh
	int n;
	read_file("do_thi_1.txt", ds_canh, &n);
	printf("Danh sach cac canh ban dau\n");
	in_ds_canh(ds_canh, n*(n-1)/2,0);
	canh T[n-1]; //
	bubble_sort(ds_canh,n*(n-1)/2);
	printf("Danh sach cac canh da sap xep\n");
	in_ds_canh(ds_canh, n*(n-1)/2,0);
	kruskal(ds_canh, n, T);
	printf("Danh sach ca canh cua cay khung nho nhat\n");
	in_ds_canh(T, n-1, 1);	
	return 0;
}