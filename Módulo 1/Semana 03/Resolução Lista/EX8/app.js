const uneDobraRetorna = (array, ...resto) =>{
    resto.forEach(
        (item)=>{
            array.push(item*2);
        }
    )
    return array;
}

const r1 = uneDobraRetorna([1, 2, 3], 4, 4);

// const r1 = uneDobraRetorna([2], 10, 4, 8);

// const r1 = uneDobraRetorna([6, 8]);

console.log(r1)