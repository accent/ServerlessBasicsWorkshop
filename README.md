# Serverless basics workshop (Azure vs AWS vs GCP)

During the workshop you will get familiar with different approaches to serverless in Azure, AWS and Google Cloud Platform (aka GCP). The main on **GCP** focus will be given. We will pass through functions, containers and storage to have a kind of full solution for hosting (frontend and backend). We won't discuss load balancers and CDNs as those are separate topics.

On all platforms they are free accounts available.

## Toolset

### Must have
* **Accounts in Azure, AWS and Google Cloud Platform**
* samples will be in C# and JavaScript - so basic knowledge would be a plus
* IDE (Notepad++ as minimum)
* PowerShell
* CLIs
  * [Azure CLI](https://aka.ms/installazurecliwindows)
  * [AWS CLI](https://aws.amazon.com/cli/)
 
### Absolute must have - does not come without them!  
* **Good mood**
* **Laptop, calculator or any other device when you can run the code will be useful**  

### Optional/not required but useful
* [CMDer](http://cmder.net/) might be useful
* Docker (it requires HyperV enabled, won't work with VirtualBox)
* SDKs
  * .NET Core 2 SDK
  * [Azure SDK](https://azure.microsoft.com/pl-pl/downloads/)
  * [AWS SDK](https://aws.amazon.com/tools/)
  * [Google Cloud SDK](https://cloud.google.com/sdk/)


## Additional Instructions

### Azure additional setup on Windows

Run _az login_ to login in interactive mode.

Create a resource group. We will be using it in all exercises. Name has to be unique.

> az group create --name "YOUR-RESOURCE-GROUP-NAME" --location "East US"

**We will use East US region.**

### AWS additional setup on Windows

1. Login to AWS console
2. Go to _My Security Credentials_
3. Create credentials (AWS Access Key)
4. Run AWS CLI
5. Run command _aws configure_
6. Provide _AWS Access Key ID_ and _AWS Secret Access Key_

**We will use US-EAST-1 region.**

### Google Cloud additional setup on Windows

When you create an account, you need to add a card to your account. It does not accept prepaids like Revolut.

**We will use US Central region**

## Workshop

The workshop is divided into 3 parts (from the hardest to the easiest) - containers (Docker), functions and storage solutions.

Our main journey will be done using CLIs.

At the end, we should have working application.

As main data center, choose one in USA - they are the cheapest and connectivity (latency) works fine for us (Poland) - at least for the needs of this workshop.

### Container registries

#### Azure

Create docker registry container.

> 

Login through console.

> az acr login --name your-docker-registry-name

Create service credentials in Azure Active Directory


#### AWS

#### Google

### Containers

In this excercise we will create and deploy a Docker container with web service. We will check how containers scale automatically under the load.

#### Azure

Azure supports two way to handle containers (which scales automatically).

##### Container Instances (AKS)

It is in preview phase.

> 

##### WebApp for containers

#### AWS Fargate

It is rather in preview phase than ready to use (ECS - ready to use, EKS - in preview).

#### Google Compute Engine

Unfortunately Google as the only one provider requires to organize the underlying resources (VMs) by yourself instead of deliver automated mechanism which would ensure scaling.

However there is native support of Kubernetes (Kubernetes Engine).

### Functions

We will create a simple function which will response on HTTP request.

#### Azure Functions

#### AWS Lambda

#### Google Cloud Functions

Currently in **beta**. It supports only JavaScript at this moment.

### Storage

In this excercise we will create a storage and upload a simple React application which will invoke deployed web service.

#### Azure Storage Account

##### Create storage using CLI

Create a storage account must be unique across all regions and accounts in Azure. Only lowercase letters and numbers are allowed. Required name length is 3-24 chars.

> az storage account create --resource-group "YOUR-RESOURCE-GROUP-NAME" --name "YOUR-UNIQUE-NAME"

Now we have to setup keys.

> az storage account keys list --account-name YOUR-STORAGE-ACCOUNT-NAME --resource-group YOUR-RESOURCE-GROUP-NAME --output table

When we have the keys, we need to set environment variables.

> set AZURE_STORAGE_ACCOUNT=YOUR-STORAGE-ACCOUNT-NAME
> set AZURE_STORAGE_ACCESS_KEY=KEY1

As next step we have to create a _Blob container_. Unfortunately _file share_ does not support (easy) public sharing of data.

> az storage container create --name CONTAINER-NAME

Azure cannot redirect to index.html. That's the biggest disappointment which I noticed.

##### Deploy the app using CLI

To copy the files we need to run following command:

> az storage blob upload -f FULL-SOURCE-FILE-PATH -c YOUR-CONTAINER-NAME -n BLOB-NAME

Set public read for blob:

> 

#### AWS S3

##### Create bucket using CLI


Below command creates a bucket with public read in US-EAST-1 region (default AWS region).

> aws s3api create-bucket --bucket your-custom-and-unique-name-across-aws2 --acl public-read --region us-east-1

This name has to be unique across entire AWS.

##### Deploy the app using CLI

>  aws s3 cp source_file_name s3://your-custom-and-unique-name-across-aws2

##### Enable static hosting

It enables hosting on the server for static files with index.html as default document. It may not exists, it's just mandatory to provide a filename.

> aws s3 website s3://your-custom-and-unique-name-across-aws2 --index-document index.html

The website will be available as: http://your-custom-and-unique-name-across-aws2.s3-website-us-east-1.amazonaws.com/

#### Google Cloud Storage

Considering Google's documentation, AWS is main competitor.

##### Create storage using CLI

##### Deploy the app using CLI

##### Enable static hosting

The website will be available as: http://BUCKET-NAME.storage.googleapis.com/index.html. Unfortunately Google shares same approach as Azure - _index.html_ is not default file and you cannot set up default one however when public access is set it will allow to list bucket content.

Also its audit options are poor.