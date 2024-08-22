# ARED Architecture (Action, Rule, Event-Driven Architecture)

ARED Architecture is an innovative framework that enables you to personalize your applications in an event-driven, rule-based, and action-focused manner. It allows users to dynamically manage the behavior of the application by defining customized actions and rules for specific events.

## Table of Contents

- [Features](#features)
- [Architecture](#architecture)
- [Installation](#installation)
- [Usage](#usage)
- [Scenarios](#scenarios)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features

- **Dynamic Rule Definition:** Users can create rules that define how the application responds to specific events and conditions.
- **User Actions:** With the action-based structure, users can customize various actions (e.g., data updates, notifications, UI changes).
- **Event-Driven Customization:** Users can define personalized behaviors based on specific events within the application.
- **Real-Time Updates:** Changes take effect immediately on the application, and results can be observed instantly.

## Architecture

ARED Architecture consists of three core components:

1. **Actions:**
   - The tasks that the application performs in response to specific events.
   - Example: Data update, sending an email, updating the user interface.

2. **Rules:**
   - Logical structures that define which actions will be performed under specific conditions.
   - Example: “If the user adds a product to the cart, update the cart total.”

3. **Events:**
   - Specific triggers or situations that occur within the application.
   - Example: User login, a new record is created, data is updated.

### Workflow Diagram

1. **Event Trigger:** An event occurs in the application.
2. **Rule Evaluation:** The relevant rules are evaluated when the event occurs.
3. **Action Execution:** The necessary actions are performed according to the rules.
4. **Result:** The actions are immediately reflected in the application.

## Usage

To use ARED Architecture, follow these steps:

### Creating Rules

- **Define a New Rule:** Create new rules that determine how the application will respond to specific events.
  - Example: "If a user purchases a product, send a thank-you email to the user."

- **Test the Rule:** Test the rules you create by triggering events and ensuring the actions occur correctly.

### Defining Actions

- **Add an Action:** Define the actions that the application will perform.
  - Example: "Add data to the database", "Update the user interface."

- **Associate the Action:** Link the actions you define with the relevant rules and events.

### Event Triggers

- **Define Events:** Define the events within the application.
  - Example: "User logged in", "A new record was created."

- **Test Events:** Trigger events and check if the correct actions are executed.

## Scenarios

- **Scenario 1: User Registration**
  - **Event:** A user creates a new account.
  - **Rule:** When a new user is registered, send a welcome email to the user.
  - **Action:** Send a welcome email to the user's email address.

- **Scenario 2: Shopping Cart**
  - **Event:** A user adds a product to the cart.
  - **Rule:** When a new product is added to the cart, update the cart total.
  - **Action:** Update the cart total and display the updated cart information to the user.

## Contributing

If you want to contribute to this project, please follow these steps:

1. **Fork the Repository:** Fork the project using this link.
2. **Create a New Branch:** `git checkout -b new-feature`
3. **Make Changes and Commit:** `git commit -m 'Add new feature'`
4. **Push Your Branch:** `git push origin new-feature`
5. **Open a Pull Request:** Open a new pull request on GitHub and submit your changes for review.

## License

This project is licensed under the MIT License. For more information, please refer to the LICENSE file.

## Contact

If you have any questions, feedback, or contribution suggestions, please feel free to contact me at [beratarpa@hotmail.com](mailto:beratarpa@hotmail.com).
