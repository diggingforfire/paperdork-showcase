This repository contains a little showcase with some tech relevant to the Paperdork tech stack. It's not meant to be functionally impressive, but rather a means to to talk about architectural choices, libraries, conceptual approaches and tech in general. The backend folder contains a .NET 9 minimal API project with a simple data model. The frontend folder contains nothing as of yet.

## Backend

A .NET 9 minimal API project based on Clean Architecture.

### Architecture
I really like the [C4 model for visualising software architecture](https://c4model.com/) to, well, visualise software architecture. The nice thing about the C4 model is that it is a rather lightweight means of reasoning about architecture at different abstraction levels, but it doesn't prescribe much in the way of notation like UML does. A simple partial C4 diagram of this project with a bunch of assumptions:

* Diagram here

In the basis, the backend follows a Clean (or Onion) architecture template. That is to say, the layering follows a specific pattern where domain entities live at the center. These are referenced by an application layer (which contains functional use cases, or commands and queries), which in turn is referenced by an outside layer that contains 'everything else' (i.e., presentation, infra etc). Everything is wired together using dependency injection.

In general, I like to combine this approach with vertical slices where a project structure is based on functionaliy, rather than technical categories.

### CQRS and MediatR

I like the pattern of distinguishing between reads (queries) and writes (commands). [CQRS](https://martinfowler.com/bliki/CQRS.html) makes this more explicit, but I don't think it's absolutely necessary to achieve this pattern of separation. It depends on the project and team whether you want to enforce this using CQRS, and whether it's worth the extra code and abstraction. 

The same can be said for using [MediatR](https://github.com/jbogard/MediatR), a great library that implements the mediator pattern and facilitates decoupling. It also adds a layer of indirection however, and makes things a bit harder to follow and debug. I feel this approach is better suited for larger and more monolithic services as opposed to smaller and more isolated (dare I say micro) services.

This project contains a simple example of CQRS with MediatR.

### Result pattern

### Data model

I am by no means an accountant, but I scaffolded a very simple data model to have something to work with:

* Data model here


### Cloud infra

### Other stuff

Other stuff that I haven't managed to put in here, but I think may be useful depending on context and requirements (as always, 'it depends'):

* [Serilog](https://serilog.net/)
* [OpenTelemetry](https://opentelemetry.io/)

## Frontend

I haven't had time yet to do anything here, but this could be a little demo project with [Vite](https://vite.dev/guide/) and [Vue](https://vuejs.org/).


### Testing and quality

I like using a test-first approach where testability enforces a good decoupled design. I would strive for a healthy mix between unit tests (more isolated, faster, less coverage), integration tests (units combined), and end-to-end tests (slow, no mocks, as real as possible, a lot of coverage). As long as you can deploy fast, often and consistently, you probably have enough test coverage.
