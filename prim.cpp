/*
Thuật toán Prim tìm cây khung nhỏ nhất
1. Cho U={1} và T={}
2. Chọn cạnh nhỏ nhất (u, v) sao cho u thuộc và v thuộc V-U. Thêm v vào U và (u, v) vào T.
	Việc thêm (u, v) vào T không tạo thành chi trình do u và v thuộc hai cây khác nhau.
	Lặp lại bước 2 đến khi U=V (T có n-1 cạnh).
*/

#include <stdio.h>
#define size 30
#define duongVC 3.40282e+38 //So float 32 bit lon nhat

typedef struct 
{
	float do_dai;
	int dau, cuoi;
}canh;

void read_file(char file_name[], canh a[][size], int *n)
{
	int i, j;
	FILE *f; //Khai bao f la con tro file
	f = fopen(file_name, "r");
	if (f == NULL)
	{
		printf("Loi mo file!!!");
		return;
	}
	fscanf(f, "%d", n); //Đọc số đỉnh của đồ thị(so dau tien)
	
	for(i=0; i<*n; i++)
		for(j=0; j<*n; j++)
		{
			fscanf(f, "%f", &a[i][j].do_dai);
			a[i][j].dau=i;
			a[i][j].cuoi=j;
		}
	fclose(f);
}

void in_ma_tran(canh a[][size], int n)
{
	int i, j;
	for(i=0; i<n; i++){
		for(j=0; j<n; j++)
			if(a[i][j].do_dai < duongVC)
				printf("%8.2f", a[i][j].do_dai);
			else
				printf("%8c", 236); //236 la ma ASCCII cua ky hieu vo cung lon
		printf("\n");
	}
}

void in_PA(canh T[], int n)
{
	int i;
	float tong=0.0;
	for(i=0; i<n; i++){
		printf("%3d (%d,%d)=%5.2f\n", i+1, T[i].dau+1, T[i].cuoi+1, T[i].do_dai);
		tong += T[i].do_dai;
	}
	printf("Tong do dai cac canh = %8.2f\n", tong);
}

void init(canh canh0[], int da_xet[], float canh_nn[], int dinh_gn[], int n)
{
	int u, v;
	for (u=0; u<n; u++)
	{
		da_xet[u] = 0;         //Tat ca cac dinh chua xet
		canh_nn[u] = duongVC;  //Cac khoang cach deu la vo cung lon
	}
	
	da_xet[0] = 1; //Bat dau xet dinh 0
	
	//canh0 la cac canh xuat phat tu dinh 0
	//La dong dau tien cua ma tran V
	for(v=1; v<n; v++)
	{
		if(canh0[v].do_dai < duongVC){    //chi xet dinh v ke voi dinh 0
			dinh_gn[v]=0;                //dinh da xet gan v nhat la dinh 0
			canh_nn[v]=canh0[v].do_dai; //khoang cach ngan nhat tu v den dinh 0
		}
	}
}

int chon_dinh(int da_xet[], float canh_nn[], int n)
{
	float emin = duongVC;
	int v, vmin;
	for(v=1; v<n; v++)
		if(!da_xet[v] && canh_nn[v]<emin)
		{
			emin = canh_nn[v];
			vmin = v;
		}
	return vmin;
}

void update(canh A[][size], int da_xet[], int dinh_gn[], float canh_nn[], int v, int n)
{
	int k;
	for(k=1; k<n; k++)
		if(!da_xet[k] && A[v][k].do_dai < canh_nn[k])
		{
			canh_nn[k] = A[v][k].do_dai;
			dinh_gn[k] = v;
		}
}

void prim(canh A[][size], int n, canh T[])
{
	int u, v, j;
	int da_xet[n];		//da_xet[u]==1 dinh u da xet, da_xet[u]==0 dinh u chua xet
	float canh_nn[n];   //canh_nn[v] la khoang cach ngan nhat tu v den mot trong cac dinh da xet
	int dinh_gn[n];     //dinh_gn[v] dinh da xet gan voi v nhat
		
	init(A[0], da_xet, canh_nn, dinh_gn, n); //A[0]  do dai cac canh xuat phat tu dinh 0
	
	for(j=0; j<n-1; j++)
	{
		v = chon_dinh(da_xet, canh_nn, n);
		da_xet[v] = 1;
		u = dinh_gn[v];
		T[j] = A[u][v];
		update(A, da_xet, dinh_gn, canh_nn, v, n);
	}
}

int main()
{
	canh A[size][size]; //Ma tran trong so cua do thi
	int n;
	read_file("do_thi_1.txt", A, &n);
	printf("Ma tran trong so ban dau\n");
	in_ma_tran(A, n);
	canh T[n-1]; //Phuong an la 1 mang co n-1 canh, luu tru cac canh cua cay khung
	prim(A, n, T);
	printf("\nDanh sach cac canh cua cay khung nho nhat\n");
	in_PA(T, n-1);
	return 0;
}

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	