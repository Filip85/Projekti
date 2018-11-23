#include <iostream>

using namespace std;

class VENTIL {
private:
	  double promjer;
	  int otvorenost;
	  double maks_protok;

   public:
	   friend VENTIL operator+(const VENTIL &a, const VENTIL &b);
	   VENTIL()
	   {
		   promjer = 5;
		   otvorenost = 0;
		   maks_protok = 10;
	   }

	   VENTIL(double p, int o)
	   {
		   promjer = p;
		   otvorenost = o;
	   }

	   VENTIL(double p, int o, double m)
	   {
		   promjer = p;
		   otvorenost = o;
		   maks_protok = m;
	   }

	   double protok(void)
	   {
		   if (otvorenost == 0 && maks_protok == 10)
		   {
			   return maks_protok;
		   }
	   }

	   void postaviPromjer(double p)
	   {
		   promjer = p;
	   }

	   void postaviOtvorenost(int o)
	   {
		   otvorenost = o;
	   }

	   void postaviProtok(double p)
	   {
		   if (p < 10)
		   {
			   maks_protok = p;
		   }
		   else
		   {
			   cout << "Krivi unos!" << endl;
		   }
	   }

	   void ispis1()
	   {
		   cout << "Promjer je " << promjer << endl;
	   }

	   void ispis2()
	   {
		   cout << "Otvorenost je " << otvorenost << endl;
	   }

	   void ispis3()
	   {
		   cout << "Protok je " << maks_protok << endl;
	   }
	   
	   VENTIL optereceni(const VENTIL &a, const VENTIL &b)
	   {
		   VENTIL V;

		   V.promjer = a.promjer + b.promjer;
		   V.otvorenost = a.otvorenost + b.otvorenost;
		   V.maks_protok = a.maks_protok + b.maks_protok;
		   return V;
	   }
};

int main() {
	VENTIL V1;
	VENTIL V2(3.4, 1, 5.3);
	VENTIL V3;

	V1.postaviProtok(7);
	V1.postaviPromjer(4);

	V3.optereceni(V1, V2);

	return 0;
}