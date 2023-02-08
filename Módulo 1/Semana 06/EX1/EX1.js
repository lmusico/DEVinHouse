function sleep (valor) {
    return new Promise ((res, rej) => {
        setTimeout(()=>{res(valor)},3000)
    })
}

sleep(2).then((resposta)=>console.log(resposta))