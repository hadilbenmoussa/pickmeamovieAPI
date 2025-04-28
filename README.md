# 🎬 PickMeAMovie API — .NET 9 Web API + Azure Deployment

Welcome to **PickMeAMovie**, a modern, cloud-native **.NET 9 Web API** that generates random movies by category, retrieves movie details by ID, and more — powered by the public **TMDB API**!  
This project is a showcase of cutting-edge cloud development using **Azure** and **Terraform**, designed for scalability, security, and automation.

---

## 🧠 About the Project

**PickMeAMovie API** helps users discover new movies easily:

- 🎲 Get a random movie by genre/category.
- 🔍 Retrieve movie details by ID.
- 🗂️ Browse through curated movie selections.

It connects to **The Movie Database (TMDB) API** to fetch the latest and most popular content — offering a fun and dynamic experience for any movie lover.

---

## 🛠️ Stack Overview

- **.NET 9 Web API** — Built with the latest Microsoft tech for high performance and minimal APIs.
- **Docker** — Containerized for portability and consistency across environments.
- **Terraform** — Infrastructure as Code (IaC) for reproducible and automated cloud deployments.
- **Azure Container Registry (ACR)** — Secure storage for Docker images.
- **Azure App Service (Web App for Containers)** — Managed platform to run our API effortlessly.
- **Azure Key Vault** — Centralized secrets management for ultimate security.
- **Azure Monitor & Application Insights** — Observability built in.

---

## 📈 Architecture

Here's a visual overview of the architecture we're implementing:
![alt text](https://github.com/hadilbenmoussa/pickmeamovieAPI/blob/master/Infrastructure/architecture-phase1.png)


**Flow Description:**

1. **Developer** pushes the code to **GitHub** / **Azure DevOps**.
2. **CI/CD pipeline** builds the Docker image and pushes it to **Azure Container Registry (ACR)**.
3. **Terraform** deploys infrastructure and the application onto Azure, automating provisioning of:
   - ACR
   - Azure App Service
   - Azure Key Vault
   - Azure Monitor

Secrets and configurations are managed centrally and injected securely into the running app.

---

## 🧩 Key Features

- **Dynamic Movie Discovery:** Find random movies based on category.
- **Detailed Movie Info:** Access comprehensive movie details through TMDB.
- **Modern API:** .NET 9, minimal API, OpenAPI (Swagger) documentation ready.
- **Full Cloud Automation:** No click-ops. Infrastructure and deployments are code-first.
- **Security First:** Secrets are never hardcoded. Only Key Vault access via managed identity.
- **Observability:** Integrated telemetry and insights — because you can't manage what you can't measure.
- **Scalable:** Designed with production scaling and upgrades in mind.

---

## 📜 Roadmap

| Phase | Description |
|:------|:------------|
| 1️⃣ | **Develop the .NET 9 Web API** — design, implement, and test core functionalities |
| 2️⃣ | **Set up core Azure infrastructure** with Terraform (ACR, App Service, Key Vault, Monitor) |
| 3️⃣ | **Containerize the API** with Docker and push images to ACR |
| 4️⃣ | **Deploy the API** to Azure App Service via Infrastructure-as-Code |
| 5️⃣ | **Integrate CI/CD pipeline** (GitHub Actions / Azure Pipelines) for automated builds and deployments |

---

## 🚀 Getting Started

1. **Clone** this repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   cd your-repo-name
   ```

2. **Build and run locally**:
   ```bash
   dotnet build
   dotnet run
   ```

3. **Provision Infrastructure with Terraform**:
   - Set up your Azure CLI authentication.
   - Navigate to the `/terraform` directory and apply:
     ```bash
     terraform init
     terraform apply
     ```

4. **Deploy Application**:
   - Push your changes and trigger the pipeline to build, push the image to ACR, and deploy to Azure.

---

## 🙌 Contributing

Contributions are welcome!  
If you have ideas to improve the architecture, code, or documentation — feel free to open an issue or pull request.

---

## 📄 License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

---

> "**Lights. Camera. Code!** 🎥🚀"

---

