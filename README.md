# Microservices Architecture with .NET

![Solution Architecture](./url_to_image_1)
![Command Service Architecture](./url_to_image_2)

This repository contains the codebase for building microservices using .NET. The solution demonstrates how to create a complete microservices architecture from scratch, covering key aspects such as REST API development, persistence, deployment to Kubernetes, and inter-service communication using synchronous and asynchronous messaging patterns.

## Overview

This project demonstrates how to build and deploy a microservices architecture using .NET. The solution includes multiple services, each with its own dedicated persistence layer, and demonstrates how to manage inter-service communication using both HTTP/gRPC for synchronous messaging and RabbitMQ for asynchronous messaging.

### Key Features
- **Two .NET Microservices** using the REST API pattern
- **Dedicated Persistence Layers** for each service using SQL Server
- **Deployment to Kubernetes** for managing containerized applications
- **API Gateway** to route requests to the appropriate services
- **Synchronous Messaging** between services using HTTP & gRPC
- **Asynchronous Messaging** with an Event Bus (RabbitMQ)

## Technologies Used

- **.NET Core:** Framework used for building the microservices
- **SQL Server:** Database system for persistence
- **RabbitMQ:** Message broker used for asynchronous messaging between services
- **gRPC:** Protocol for high-performance RPC calls between microservices
- **Kubernetes:** Platform for automating deployment, scaling, and operations of application containers
- **Docker:** Used for containerizing the microservices
- **API Gateway:** Manages and routes incoming API requests to various microservices

## Architecture

### Solution Architecture
The architecture is designed to support internal microservices communication within a domain. It includes a central API Gateway that routes requests to various services, which communicate with each other using gRPC for synchronous calls and RabbitMQ for asynchronous messaging.

### Command Service Architecture
This service handles incoming requests both synchronously through HTTP and gRPC and asynchronously via a message bus. The service processes commands and interacts with a SQL Server database for persistence.

## How to Run

### Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [Kubernetes](https://kubernetes.io/docs/tasks/tools/)
- [RabbitMQ](https://www.rabbitmq.com/download.html)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Steps to Run Locally
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
    - Apply the configurations using `kubectl apply -f <file_name>.yaml`.

4. **Access the Services:**
    - API Gateway: `http://localhost:5000`
    - RabbitMQ Management: `http://localhost:15672`
    - SQL Server: Use SQL Server Management Studio or other tools to connect.

## Screenshots

- **Solution Architecture**:
    ![Solution Architecture](![image](https://github.com/user-attachments/assets/9196abd2-4628-4c1d-b156-76841c8b3c51)
)
- **Command Service Architecture**:
    ![Command Service Architecture](![image](https://github.com/user-attachments/assets/4a2458f9-c743-4add-a724-ed53ad6d2fca)
)

---

