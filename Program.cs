
using static System.Console;
Clear();

//1. Crear el carto de bingo de 3 filas y 9 columnas (Matriz[3,9]
string[,] carton = new string[3, 9];
Random num = new Random();
Random blank = new Random();


//Rellenar el carton con numeros unicos:
//6. La primer columna contiene los numeros del 1-9
//   La segunda del 10-19
//   La tercera del 20-29
//   La cuarta del 30-39
//   La quinta del 40-49
//   La sexta del 50-59
//   La septima del 60-69
//   La octava del 70-79
//   La novena del 80-90
for (int i = 0; i == 0; i++)
{

    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(1, 9).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(1, 9).ToString();
                    l = -1;
                }
            }
            loop = false;
        }

    }
}

for (int i = 1; i == 1; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(10, 19).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(10, 19).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 2; i == 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(20, 29).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(20, 29).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 3; i == 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(30, 39).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(30, 39).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 4; i == 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(40, 49).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(40, 49).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 5; i == 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(50, 59).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(50, 59).ToString();
                    l = -1;
                }
            }
            loop = false;
        }

    }
}

for (int i = 6; i == 6; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(60, 69).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(60, 69).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 7; i == 7; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(70, 79).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(70, 79).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 8; i == 8; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton[j, i] = num.Next(80, 90).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton[j, i] == carton[l, i])
                {
                    carton[j, i] = num.Next(80, 90).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}


/*
//Ordenar la matriz de forma ascendente con bubble sort
int aux = 0;
int pointer1 = 0;
int pointer2 = 0;
for (int j = 0; j < 9; j++)
{
    for (int i = 0; i < 2; i++)
    {
        pointer1 = i;
        pointer2 = i + 1;
        do
        {
            if (carton[pointer1, j] > carton[pointer2, j])
            {
                pointer1 = pointer2;
            }
            pointer2++;
        }
        while (pointer2 <= 2);
        if (i != pointer1)
        {
            aux = carton[i, j];
            carton[i, j] = carton[pointer1, j];
            carton[pointer1, j] = aux;
        }
    }
}
*/


//Agregar espacios en blanco
//fila 1
for (int j = 0; j == 0; j++)
{
    int space = blank.Next(1, 2);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = blank.Next(4, 5);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = blank.Next(6, 7);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = blank.Next(7, 9);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

//fila 2
for (int j = 1; j == 1; j++)
{
    int space = blank.Next(0, 1);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = blank.Next(3, 4);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}



for (int j = 1; j == 1; j++)
{
    int space = blank.Next(2, 3);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = blank.Next(5, 9);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

//fila 3
for (int j = 2; j == 2; j++)
{
    int space = blank.Next(5, 6);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = blank.Next(7, 8);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = blank.Next(8, 9);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = blank.Next(0, 5);
    for (int i = space; i == space; i++)
    {
        carton[j, i] = " ";

    }
}


//Imprimir caton
WriteLine("Carton 1:");
for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 9; i++)
    {

        Write($"| {carton[j, i]} ");


    }
    WriteLine();
}






//==================================================================== CARTON 2 ============================================================//
WriteLine();
WriteLine("=================================================================================================================================");
WriteLine();

//1. Crear el carto de bingo de 3 filas y 9 columnas (Matriz[3,9]
string[,] carton2 = new string[3, 9];
Random num2 = new Random();
Random blank2 = new Random();


//Rellenar el carton con numeros unicos:
//6. La primer columna contiene los numeros del 1-9
//   La segunda del 10-19
//   La tercera del 20-29
//   La cuarta del 30-39
//   La quinta del 40-49
//   La sexta del 50-59
//   La septima del 60-69
//   La octava del 70-79
//   La novena del 80-90
for (int i = 0; i == 0; i++)
{

    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(1, 9).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(1, 9).ToString();
                    l = -1;
                }
            }
            loop = false;
        }

    }
}

for (int i = 1; i == 1; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(10, 19).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(10, 19).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 2; i == 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(20, 29).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(20, 29).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 3; i == 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(30, 39).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(30, 39).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 4; i == 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(40, 49).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(40, 49).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 5; i == 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(50, 59).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(50, 59).ToString();
                    l = -1;
                }
            }
            loop = false;
        }

    }
}

for (int i = 6; i == 6; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(60, 69).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(60, 69).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 7; i == 7; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(70, 79).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(70, 79).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}

for (int i = 8; i == 8; i++)
{
    for (int j = 0; j < 3; j++)
    {
        carton2[j, i] = num2.Next(80, 90).ToString();
        bool loop = true;
        while (loop == true)
        {
            for (int l = 0; l < j; l++)
            {
                if (carton2[j, i] == carton2[l, i])
                {
                    carton2[j, i] = num2.Next(80, 90).ToString();
                    l = -1;
                }
            }
            loop = false;
        }
    }
}


/*
//Ordenar la matriz de forma ascendente con bubble sort
int aux = 0;
int pointer1 = 0;
int pointer2 = 0;
for (int j = 0; j < 9; j++)
{
    for (int i = 0; i < 2; i++)
    {
        pointer1 = i;
        pointer2 = i + 1;
        do
        {
            if (carton[pointer1, j] > carton[pointer2, j])
            {
                pointer1 = pointer2;
            }
            pointer2++;
        }
        while (pointer2 <= 2);
        if (i != pointer1)
        {
            aux = carton[i, j];
            carton[i, j] = carton[pointer1, j];
            carton[pointer1, j] = aux;
        }
    }
}
*/


//Agregar espacios en blanco
//fila 1
for (int j = 0; j == 0; j++)
{
    int space = blank2.Next(1, 2);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = blank2.Next(4, 5);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = blank2.Next(6, 7);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 0; j == 0; j++)
{
    int space = blank2.Next(7, 9);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

//fila 2
for (int j = 1; j == 1; j++)
{
    int space = blank2.Next(0, 1);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = blank2.Next(3, 4);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}



for (int j = 1; j == 1; j++)
{
    int space = blank2.Next(2, 3);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 1; j == 1; j++)
{
    int space = blank2.Next(5, 9);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

//fila 3
for (int j = 2; j == 2; j++)
{
    int space = blank2.Next(5, 6);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = blank2.Next(7, 8);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = blank2.Next(8, 9);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}

for (int j = 2; j == 2; j++)
{
    int space = blank2.Next(0, 5);
    for (int i = space; i == space; i++)
    {
        carton2[j, i] = " ";

    }
}


//Imprimir caton
WriteLine("Carton 2:");
for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 9; i++)
    {

        Write($"| {carton2[j, i]} ");


    }
    WriteLine();
}