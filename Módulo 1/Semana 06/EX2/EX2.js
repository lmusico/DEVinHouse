const time = () => {
    
    setInterval(() => {
        const t = new Date();
        setTimeout(()=>clearInterval(), 5000);
        console.log(t.getHours(),":",t.getMinutes(),":",t.getSeconds());
    }, 1000);
    
}

time();