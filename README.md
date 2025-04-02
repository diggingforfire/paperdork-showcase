This repository contains a little showcase with some tech relevant to the Paperdork tech stack. It's not meant to be functionally impressive, but rather a means to to talk about architectural choices, libraries, conceptual approaches and tech in general. The backend folder contains a .NET 9 minimal API project with a simple data model. The frontend folder contains nothing as of yet.

## Backend

A .NET 9 minimal API project based on Clean Architecture.

### Architecture
I really like the [C4 model for visualising software architecture](https://c4model.com/) to, well, visualise software architecture. The nice thing about the C4 model is that it is a rather lightweight means of reasoning about architecture at different abstraction levels, but it doesn't prescribe much in the way of notation (like UML does). 

In the basis, the backend follows a Clean (or Onion) architecture template. That is to say, the layering follows a specific pattern where domain entities live at the center. These are referenced by an application layer (which contains functional use cases, or commands and queries), which in turn is referenced by an outside layer that contains 'everything else' (i.e., presentation, infra etc). Everything is wired together using dependency injection.

In general, I like to combine this approach with vertical slices where a project structure is based on functionaliy, rather than technical categories.

### Data model

I am by no means an accountant, but I scaffolded a very simple data model to have something to work with:

* Data model here


### Infra

### Other stuff

Other stuff that I haven't managed to put in here, but I think may be useful depending on your requirements:

* 1
* 2
* 3

## Frontend

I haven't had time yet to do anything here, but this could be a little demo project with [Vite](https://vite.dev/guide/) and [Vue](https://vuejs.org/).
