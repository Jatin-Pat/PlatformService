# Microservices Architecture with .NET 🚀

![Solution Architecture](./url_to_image_1)
![Command Service Architecture](./url_to_image_2)

![.NET Core](https://img.shields.io/badge/.NET_Core-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)
![Kubernetes](https://img.shields.io/badge/Kubernetes-326CE5?style=for-the-badge&logo=kubernetes&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-FF6600?style=for-the-badge&logo=rabbitmq&logoColor=white)
![gRPC](https://img.shields.io/badge/gRPC-4285F4?style=for-the-badge&logo=google&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)

## 🌟 Overview

Welcome to the **Microservices Architecture with .NET** repository! This project is a comprehensive demonstration of how to build and deploy a microservices architecture using .NET. The solution includes multiple services, each with its own dedicated persistence layer, and showcases inter-service communication using both synchronous (HTTP/gRPC) and asynchronous (RabbitMQ) messaging patterns.

### 🔑 Key Features
- **Two .NET Microservices** using the REST API pattern
- **Dedicated Persistence Layers** for each service using SQL Server
- **Deployment to Kubernetes** for managing containerized applications
- **API Gateway** to route requests to the appropriate services
- **Synchronous Messaging** between services using HTTP & gRPC
- **Asynchronous Messaging** with an Event Bus (RabbitMQ)

## 🛠️ Technologies Used

- **.NET Core:** Framework used for building the microservices
- **SQL Server:** Database system for persistence
- **RabbitMQ:** Message broker used for asynchronous messaging between services
- **gRPC:** Protocol for high-performance RPC calls between microservices
- **Kubernetes:** Platform for automating deployment, scaling, and operations of application containers
- **Docker:** Used for containerizing the microservices
- **API Gateway:** Manages and routes incoming API requests to various microservices

## 🏛️ Architecture

### 🌐 Solution Architecture
The architecture is designed to support internal microservices communication within a domain. It includes a central API Gateway that routes requests to various services, which communicate with each other using gRPC for synchronous calls and RabbitMQ for asynchronous messaging.

<details>
<summary>View Architecture Diagram</summary>

![Solution Architecture](./url_to_image_1)

</details>

### 🧩 Command Service Architecture
This service handles incoming requests both synchronously through HTTP and gRPC and asynchronously via a message bus. The service processes commands and interacts with a SQL Server database for persistence.

<details>
<summary>View Command Service Diagram</summary>

![Command Service Architecture](./url_to_image_2)

</details>

## 🚀 How to Run

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [Kubernetes](https://kubernetes.io/docs/tasks/tools/)
- [RabbitMQ](https://www.rabbitmq.com/download.html)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### ⚙️ Steps to Run Locally

1. **Clone the repository:**
    ```bash
    git clone https://github.com/your-username/your-repo-name.git
    cd your-repo-name
    ```

2. **Build and run the services using Docker:**
    ```bash
    docker-compose up --build
    ```

3. **Deploy to Kubernetes:**
    - Use the Kubernetes deployment files provided in the `/k8s` directory.
    - Apply the configurations using:
    ```bash
    kubectl apply -f <file_name>.yaml
    ```

4. **Access the Services:**
    - **API Gateway:** `http://localhost:5000`
    - **RabbitMQ Management:** `http://localhost:15672`
    - **SQL Server:** Use SQL Server Management Studio or other tools to connect.

## 📸 Screenshots

- **Solution Architecture**:
    ![Solution Architecture](![videoframe_2619726](https://github.com/user-attachments/assets/69dc4c7c-2479-446d-bdf9-9c63ddf412e2)
- **Command Service Architecture**:
    ![Command Service Architecture](![videoframe_2759726](https://github.com/user-attachments/assets/38c659cd-93f0-4455-bdb0-86bc92e3484f)
---
