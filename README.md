# Serverless basics workshop (Azure vs AWS vs GCP)

During the workshop you will get familiar with different approaches to serverless in Azure, AWS and Google Cloud Platform (aka GCP). The main on **GCP** focus will be given. We will pass through functions, containers and storage to have a kind of full solution for hosting (frontend and backend). We won't discuss load balancers and CDNs as those are separate topics.

On all platforms they are free accounts available.

## Required components

Please get/install following components (and accounts) before workshop.

* Docker
* IDE (Notepad++ as minimum)
* .NET Core 2 SDK
* PowerShell
* [CMDer](http://cmder.net/)
* [Azure SDK](https://azure.microsoft.com/pl-pl/downloads/)
* [AWS SDK](https://aws.amazon.com/tools/)
* [Google Cloud SDK](https://cloud.google.com/sdk/)
* **Accounts in Azure, AWS and Google Cloud Platform**
* samples will be in C# and JavaScript
* **Good mood**
* **Laptop, calculator or any other device when you can run the code will be useful**

## Additional Instructions
### GCP setup on Windows


## Workshop

The workshop is divided into 3 parts (from the hardest to the easiest) - containers (Docker), functions and storage solutions.


### Containers

In this excercise we will create and deploy a Docker container with web service. We will check how containers scale automatically under the load.

#### Azure

Azure supports two way to handle containers (which scales automatically).

##### Container Instances

##### WebApp for containers

#### AWS Fargate

#### Google Compute Engine

Unfortunately Google as the only one provider requires to organize the underlying resources (VMs) by yourself instead of deliver automated mechanism which would ensure scaling.

### Functions

#### Azure Functions

#### AWS Lambda

#### Google Cloud Functions


### Storage

In this excercise we will create a storage and upload a simple Angular or React application which will invoke deployed web service.

#### Azure Storage Account

##### Create an account using CLI

#### AWS S3

##### Create an account using CLI

#### Google Cloud Storage

##### Create an account using CLI