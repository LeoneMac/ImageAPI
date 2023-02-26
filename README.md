# ImageAPI

For testing the API with Visual Studio, you can run the application: ![image](https://user-images.githubusercontent.com/87988016/221443878-7af22cd3-1cf4-4393-85d7-5bae46a7ab9f.png) and in Postman, using the route localhost:[port]/ImageConversion
My route: 
![image](https://user-images.githubusercontent.com/87988016/221443982-68b09e24-8984-43b7-93a2-95a60282eda0.png)
Then, running the solution, we use form-data in Postman to send a file, uploading what we want to convert. 
![image](https://user-images.githubusercontent.com/87988016/221444082-03f277c2-7a8a-4851-af96-15ee7e019dbf.png)
You should receive a json response with the base64 string like this.
![image](https://user-images.githubusercontent.com/87988016/221444120-b10b1815-94e2-4922-b9b4-9bdda6837ac4.png)
Careful, remember that converting to base64 get your file bigger, do whatever you want with this information. In the example, i'm sending a JPG with 3,63MB, but the response size is 4.85 MB.
Even streaming the file with maximum 2MB/s and limiting just one file per upload in the post, the application can be used for many users sending and receiving imgs/large strings, larger the image, large the string YOU are uploading back in the body response, so pay attention.
