# Clean Architecture
* [Domain Layer](#domain-layer)
* [Application Layer](#application-layer)
* [Infrastructure Layer](#infrastructure-layer)
* [Presentation Layer](#presentation-layer)
![system schema](./images/clean-architecture.png "A title")

# Domain Layer
* Entities
* Value Objects
* Domain Events
* Domain Services
* Interfaces
* Exceptions
* Enums

[More detail](Domain%20Layer.md)

# Application Layer
* Orchestrates the Domain
* Contains Business Logic
* Defines Use Cases
  * Application Services
  * CQRS (with Mediatr for example)
* Authorization

[More detail](Application%20Layer.md)

# Infrastructure Layer
Interacts with External Systems:
* Databases
  * Implements DB Context
  * Implements Repositories
* Messaging
* Email Providers
* Storage Services 
* Identity Provider
* System Clock

[More detail](Infrastructure%20Layer.md)

# Presentation Layer
Responsible for interacting with the users.

* Defines the Entry Point to the System
* gRPC Service
* REST API
  * API Endpoints
  * Middleware
  * DI Setup
* Authentication

[More detail](Presentation%20Layer.md)
