'use strict'
let n = parseInt(prompt("Введите количество процессов(1-10):"));
let a = []
let sum = 0

for (let i=0; i<n; i++)
{
    document.write("P" + i + ":")
    a[i] = parseInt(prompt('Введите продолжительность ' + 'p' + i + ':'));
    document.write(a[i] + "<br>")
    sum = sum + a[i] 
}

document.write("<br>")

let a_ish = a

let a_sort = a.slice(0).sort()

let b=[]

for (let i = 0; i < n; i++) {
	b[i] = []; 
	
	for (let j = 0; j < sum; j++) {
		b[i][j] = '0' 
    }
}

let kolI = []

for (let i=0; i<n; i++)
{
    for (let j=0; j<n; j++)
    {
        if (a_sort[i] == a_ish[j]) 
        {
            for (let z=0; z<a[j]; z++)
            {
                b[j][z] = b[j][z].replace('0', 'И')
            }
        }
    }
}

for (let i=0; i<n; i++)
{
    kolI[i] = 0
    for (let j=0; j<sum; j++)
    {
        if (b[i][j] == 'И')
            kolI[i] += 1
    }
}

let kolG = 0;
let kolG_a = []
for (let i=1; i<n; i++)
{
    for (let j=0; j<n; j++)
    {
        if (a_sort[i] == a_ish[j])
        {
            for (let z=0; z<a_sort[i-1]; z++)
            {
                b[j][z + kolI[j]] = b[j][z + kolI[j]].replace('0', 'Г')
                kolG = kolG + 1
            }
        }
    }
    kolG_a[i] = kolG
}

for (let i=1; i<n; i++)
{
    for (let j=0; j<n; j++)
    {
        if (a_sort[i] == a_ish[j])
        {
            for (let z=0; z<kolG_a[i]; z++)
            {
                b[j][z + kolI[j]] = b[j][z + kolI[j]].replace('0', 'Г')
            }
        }
    }
}

for (let i=0; i<n; i++)
{
    document.write('p' +  i + ': ')
    for (let j=sum-1; j>=0; j--)
    {
        if (b[i][j] == 0)
            continue
        else
            document.write(b[i][j] + ' ')
    }
    document.write('<br>')
}

document.write('Суммарное время выполения: ' + sum)