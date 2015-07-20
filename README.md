# OWIN.Docker

A simple **"Hello Sogeti"** sample, using **OWIN**, **WebAPI** and a corresponding **dockerfile** so you can create an image and run it as container!

> It's real easy to test Docker on Microsoft Azure, just create a VM based on the following image: [Docker on Ubuntu Server](https://azure.microsoft.com/en-us/marketplace/partners/canonicalandmsopentech/dockeronubuntuserver1404lts/)

Steps to run the application as a Docker container:

* Copy the [dockerfile](https://github.com/SogetiSpain/OWIN.Docker/blob/master/src/dockerfile) to your Docker server (i.e. host)
* Create an image (i.e. hello_sogeti):
    ```
    sudo docker build -t hello_sogeti .
    ```
* Run the image:
    ```
    docker run -t -d -p 9000:9000 hello_sogeti
    ```
* Browse to the following url:
    ```
    [host]:9000/api/hello/get
    ```
* Your browser should show:
  ```
  "Hello Sogeti!"
  ```
