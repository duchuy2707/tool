
class Sudoku {
    input = [];

    timeSolution = {
        start: 0,
        end: 0,
    }

    #checkDuplicates = (arr) => {
        const a = arr.filter(i => i !== 0);
        return (new Set(a)).size !== a.length;
    }

    #getStartIndexSquare = (index) => {
        if (index <= 2) return 0;
        if (index <= 5) return 3;
        return 6;
    };

    #getArraySquareByIndex = (data, index) => {
        const arrS = [];
        for (let i = index.x; i < index.x + 3; i++) {
            for (let j = index.y; j < index.y + 3; j++) {
                arrS.push(data[i][j]);
            }
        }
        return arrS;
    }

    #getValueNotHaveWrite = (arr) => {
        for (let i = 1; i <= 9; i++) {
            if (arr.indexOf(i) === -1) return i;
        }
        return 0;
    }

    #getAnyValuePossibleWrite = (arr) => {
        const result = [];

        for (let i = 1; i <= 9; i++) {
            if (arr.indexOf(i) === -1) result.push(i)
        }

        return result;
    }

    #getIndexZero = (arr) => {
        const result = [];

        for (let i = 0; i < arr.length; i++) {
            if (arr[i] === 0) result.push(i);
        }

        return result;
    }

    #check = (data, index) => {
        if (index === undefined) {
            for (let i = 0; i < data.length; i++) {
                if (!this.#check(data, i)) return false;
            }

            return true;
        } else if (index.x !== undefined) {
            const arrX = data[index.x];
            const arrY = data.map(d => d[index.y]);
            const arrS = this.#getArraySquareByIndex(data, { x: this.#getStartIndexSquare(index.x), y: this.#getStartIndexSquare(index.y) });

            if (this.#checkDuplicates(arrX) || this.#checkDuplicates(arrY) || this.#checkDuplicates(arrS)) return false;
            return true;
        } else if (index !== undefined) {
            for (let i = 0; i < data[index].length; i++) {
                if (!this.#check(data, { x: index, y: i })) return false;
            }

            return true;
        }

        return false;
    }

    #writeValue = (array, data, indexRow) => {
        const arr = [...array];
        for (let i = 0; i < arr.length; i++) {
            if (arr[i] === 0) {
                const cloneData = [...data];
                arr[i] = this.#getValueNotHaveWrite(arr);
                cloneData[indexRow] = arr;

                if (!this.#check(cloneData, { x: indexRow, y: i })) return [];
            }
        }
        return arr;
    }


    #randomValue = (data, indexRow, array, index = 0, result = []) => {
        const t1 = [...array];
        const arrIndexZero = this.#getIndexZero(array);
        const arrValuePositive = this.#getAnyValuePossibleWrite(array);

        if (arrIndexZero.length === 2) {
            t1[arrIndexZero[0]] = arrValuePositive[index];

            const cloneData = [...data];
            cloneData[indexRow] = t1;

            if (check(cloneData, { x: indexRow, y: arrIndexZero[0] })) {
                const newRow = this.#writeValue(t1, data, indexRow);
                if (newRow.length !== 0) result.push(newRow);
            }

            if (index === arrIndexZero.length - 1) return result;

            this.#randomValue(data, indexRow, array, index + 1, result);
        } else {
            for (let i = 0; i < arrIndexZero.length; i++) {
                t1[arrIndexZero[0]] = arrValuePositive[i];
                const cloneData = [...data];
                cloneData[indexRow] = t1;

                if (this.#check(cloneData, { x: indexRow, y: arrIndexZero[0] })) this.#randomValue(data, indexRow, t1, 0, result);
            }

            return result;
        }
    }

    #getAllRowRandom = (data) => {
        const matrix = [...data];
        const arrRandomData = [];

        for (let i = 0; i < matrix.length; i++) {
            arrRandomData.push(this.#randomValue(matrix, i, matrix[i]));
        }

        return arrRandomData;
    }

    #removeItemIllegal = (matrix, arrRandomData, minArray, maxArray) => {
        for (let i = 0; i < arrRandomData[minArray].length; i++) {
            matrix[minArray] = arrRandomData[minArray][i];
            for (let j = 0; j < arrRandomData[maxArray].length; j++) {
                matrix[maxArray] = arrRandomData[maxArray][i];

                if (!check(matrix, maxArray)) {
                    arrRandomData[maxArray].splice(j, 1);
                }
            }
        }
    }

    constructor(arr = []) {
        this.input = arr;
    }

    init(arr = []) {
        this.input = arr;
        return this;
    }

    solution() {
        console.log('start', (new Date()).getTime());
        const matrix = [...this.input];
        const arrRandomData = this.#getAllRowRandom(matrix);

        console.log(arrRandomData);

        const recursive = (index) => {
            for (let i = 0; i < arrRandomData[index].length; i++) {
                matrix[index] = arrRandomData[index][i];

                if (check(matrix, index)) {
                    if (index === arrRandomData.length - 1) return matrix;
                    else {
                        const r = recursive(index + 1);
                        if (r) return r;
                    }
                }
            }

            if (index !== 0) matrix[index] = [...this.input[index]];
            return false;
        }

        if (recursive(0)) return matrix;

        return false;
    }
}

const s = new Sudoku([
    [0, 0, 3, 0, 0, 4, 0, 5, 8],
    [6, 0, 0, 1, 0, 0, 0, 0, 2],
    [2, 0, 4, 0, 0, 0, 0, 0, 0],
    [0, 7, 9, 0, 0, 0, 0, 0, 0],
    [1, 0, 0, 0, 8, 0, 3, 0, 0],
    [0, 0, 0, 6, 0, 0, 0, 0, 0],
    [3, 0, 5, 0, 0, 8, 0, 9, 0],
    [0, 2, 0, 0, 9, 0, 0, 0, 1],
    [8, 0, 0, 0, 0, 0, 0, 0, 0],
]);

console.log(s.solution());
console.log('end', (new Date()).getTime());

const s1 = new Sudoku([
    [0, 0, 0, 6, 8, 0, 0, 0, 0],
    [0, 6, 0, 0, 0, 0, 5, 0, 0],
    [5, 0, 0, 0, 3, 0, 0, 0, 0],
    [0, 0, 0, 9, 2, 0, 0, 0, 0],
    [0, 0, 6, 0, 0, 0, 0, 0, 1],
    [3, 4, 0, 0, 0, 0, 0, 0, 6],
    [0, 1, 0, 3, 0, 0, 0, 0, 7],
    [0, 0, 7, 0, 0, 0, 9, 0, 0],
    [0, 8, 0, 0, 9, 0, 2, 5, 0],
]);

console.log(s1.solution());
console.log('end', (new Date()).getTime());