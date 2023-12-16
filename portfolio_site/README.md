# Overview

As a software engineer committed to continuous learning and improvement, I have developed a dynamic web application showcasing a portfolio of projects. This application serves as a practical way to demonstrate my understanding of web development concepts using Django, a high-level Python web framework.

To view the web app locally, one can start the test server by running `python manage.py runserver` in the terminal from the project's root directory. Then, by navigating to `http://127.0.0.1:8000/` on a web browser, the homepage of the app is displayed, showcasing various projects dynamically pulled from the database.

The purpose of writing this software was to understand the full stack development process, including back-end logic with Django and front-end presentation with HTML, CSS, and usually JavaScript. Additionally, it was an exercise in data persistence and web server management.

[Software Demo Video](https://youtu.be/Cqa-1FUOrDs)

# Web Pages

The web app consists of the following pages:
- **Home Page**: Displays a list of projects. Each project card is dynamically created based on the entries in the database.
- **Project Detail Page**: Accessed by clicking on a project card from the Home Page, it shows more detailed information about the project, including descriptions and images.
- **About Page**: Provides information about the developer and the context of the app's creation.

The transition between pages is smooth, with URLs mapped to Django views rendering the respective templates.

# Development Environment

The primary tools used for the development of this web app include:
- Visual Studio Code as the code editor
- Django framework for constructing the web app
- SQLite for the database backend
- Git for version control

The programming languages used were Python for the server-side logic, HTML, CSS for the front-end layout and styling, and JavaScript for client-side scripting.

# Useful Websites

The following websites were invaluable for learning and troubleshooting throughout the project:
* [Django Documentation](https://docs.djangoproject.com/en/3.2/)
* [MDN Web Docs](https://developer.mozilla.org/en-US/)
* [Stack Overflow](https://stackoverflow.com/)

# Future Work

Improvements and additions that are planned for future iterations of the project include:
* Implementation of user authentication for personalized experiences.
* Integration of a third-party database like PostgreSQL for production readiness.
* Development of a responsive design to ensure compatibility across various devices.
