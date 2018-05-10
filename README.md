# Serverless basics workshop (Azure vs AWS vs GCP)

During the workshop you will get familiar with different approaches to serverless in Azure, AWS and Google Cloud Platform (aka GCP). The main on **GCP** focus will be given. We will pass through functions, containers and storage to have a kind of full solution for hosting (frontend and backend). We won't discuss load balancers and CDNs as those are separate topics.

On all platforms they are free accounts available.

## Required components

Please get/install following components (and accounts) before workshop.

* IDE (Notepad++ as minimum)
* .NET Core 2 SDK
* PowerShell
* [CMDer](http://cmder.net/) might be useful
* [Azure SDK](https://azure.microsoft.com/pl-pl/downloads/)
* [Azure CLI](https://aka.ms/installazurecliwindows)
* [AWS SDK](https://aws.amazon.com/tools/)
* [AWS CLI](https://aws.amazon.com/cli/)
* [Google Cloud SDK](https://cloud.google.com/sdk/)
* Docker
* **Accounts in Azure, AWS and Google Cloud Platform**
* samples will be in C# and JavaScript
* **Good mood**
* **Laptop, calculator or any other device when you can run the code will be useful**

## Additional Instructions
### GCP setup on Windows

### AWS CLI setup on Windows

1. Login to AWS console
2. Go to _My Security Credentials_
3. Create credentials (AWS Access Key)
4. Run AWS CLI
5. Run command _aws configure_
6. Provide _AWS Access Key ID_ and _AWS Secret Access Key_

## Workshop

The workshop is divided into 3 parts (from the hardest to the easiest) - containers (Docker), functions and storage solutions.

Our main journey will be done using CLIs.

At the end, we should have working application.

As main data center, choose one in USA - they are the cheapest and connectivity (latency) works fine for us (Poland) - at least for the needs of this workshop.

### Containers

In this excercise we will create and deploy a Docker container with web service. We will check how containers scale automatically under the load.

#### Azure

Azure supports two way to handle containers (which scales automatically).

##### Container Instances

> 

##### WebApp for containers

#### AWS Fargate

It is rather in preview phase than ready to use (ECS - ready to use, EKS - in preview).

#### Google Compute Engine

Unfortunately Google as the only one provider requires to organize the underlying resources (VMs) by yourself instead of deliver automated mechanism which would ensure scaling.

### Functions

#### Azure Functions

#### AWS Lambda

#### Google Cloud Functions


### Storage

In this excercise we will create a storage and upload a simple React application which will invoke deployed web service.

#### Azure Storage Account

##### Create storage using CLI

##### Deploy the app using CLI

#### AWS S3

##### Create bucket using CLI

Below command creates a bucket with public read in US-EAST-1 region (default AWS region).

> aws s3api create-bucket --bucket your-custom-and-unique-name-across-aws2 --acl public-read --region us-east-1

##### Deploy the app using CLI

##### Enable static hosting

#### Google Cloud Storage

##### Create storage using CLI

##### Deploy the app using CLI