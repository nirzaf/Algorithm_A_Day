﻿let matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

//5 is the number of rows and 4 is the number of columns.
const matrix2 = new Array(5).fill(0).map(() => new Array(4).fill(0));

let Array2D = (r, c) => [...Array(r)].map(x => Array(c).fill(0));

let m = Array2D(3, 5);

let m4 = new Array(4);
for (let i = 0; i < m4.length; i++) {
    m4[i] = new Array(3);
}


function spiralOrder(matrix) {
    let result = [];
    if (matrix === null || matrix.length === 0) return result;

    let currentRow = 0;
    let currentColumn = 0;
    let lastRow = matrix.length - 1;
    let lastColumn = matrix[0].length - 1;

    while (currentRow <= lastRow && currentColumn <= lastColumn) {

        for (let i = currentColumn; i <= lastColumn; i++) {
            result.push(matrix[currentRow][i]);
        };
        currentRow++;

        for (let i = currentRow; i <= lastRow; i++) {
            result.push(matrix[i][lastColumn]);
        };
        lastColumn--;

        if (currentRow <= lastRow) {
            for (let i = lastColumn; i >= currentColumn; i--) {
                result.push(matrix[lastRow][i]);
            };
            lastRow--;
        };
        
        if (currentColumn <= lastColumn) {
            for (let i = lastRow; i >= currentRow; i--) {
                result.push(matrix[i][currentColumn]);
            };
            currentColumn++;
        }; 
    }
    return result;
    
}