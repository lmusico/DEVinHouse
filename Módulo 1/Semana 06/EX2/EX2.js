const time = () => {
    
    setInterval(() => {
        const t = new Date();
        console.log(t.toLocaleTimeString());
    }, 1000);
    
}

time();