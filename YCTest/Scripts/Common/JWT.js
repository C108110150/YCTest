///JWT生成  token method 智慧化告警
async function JWTGenerate(method) {
    try {
        const res = await fetch('/Home/JWTGenerate', {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({ method: method })
        })
        const jwtToken = res.json();
        return jwtToken;

    } catch (err) { console.error('JWTGenerate ERR', err) }
    /*$.ajax({
        url: '/Home/JWTGenerate',
        type: "POST",
        dataType: "json",
        data: { method: method },
        success: function (Token) {
            callback(null, Token);  
        },
        error: function (error) {
            callback("系統錯誤送出失敗!", null);  
        }
    });*/
}

async function GetAPIData(method) {
    const Token = await JWTGenerate(method);
    //const url = `https://kap.kcg.gov.tw/KAPApi/Frontend/FrontendInfo?token=${encodeURIComponent(Token)}`;
    const url = `https://testkap.pstcom.com.tw/KAPApi/Frontend/FrontendInfo?token=${encodeURIComponent(Token)}`;
    try {
        const res = await fetch(url, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!res.ok) throw new Error(res.json());

        const data = (await res.json()).data;
        return data;
    }
    catch (err) { console.error('GetAPIData ERR', err); }
    /*JWTGenerate(method, function (error, Token) {
        if (error) {
            console.error(error);
        } else {
            //const url = `https://localhost:7058/Frontend/FrontendInfo?token=${encodeURIComponent(Token)}`;
            const url = `https://testkap.pstcom.com.tw/KAPApi/Frontend/FrontendInfo?token=${encodeURIComponent(Token)}`;


            fetch(url, {
                method: 'GET',
                headers: {
                    'Content-Type': 'application/json'
                }
            })
                .then(response => {
                    if (!response.ok) {
                        throw new Error('Network response was not ok');
                    }
                    return response.json();
                })
                .then(data => {
                    callback(data)
                })
                .catch(error => {
                    console.error('Fetch error:', error);
                });
        }
    });*/
}