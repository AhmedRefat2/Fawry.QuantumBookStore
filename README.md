# 📚 Quantum Bookstore

Quantum Bookstore is a console-based application that simulates a simple, extensible online bookstore.  
It supports different types of books including physical, digital, and demo-only books — with functionalities for managing inventory, purchasing, and removing outdated items.

---

## 🚀 Features

- Add books to inventory (`PaperBook`, `EBook`, `ShowcaseBook`)
- Remove outdated books based on publication year
- Buy books:
  - Paper books are shipped to a physical address
  - EBooks are sent via email
  - Showcase books are **not for sale**
- All console outputs are prefixed with `Quantum book store`

---

## 🏗️ Book Types

| Book Type      | Description                                     |
|----------------|-------------------------------------------------|
| `PaperBook`    | Has physical stock and is shipped               |
| `EBook`        | Has a file type and is sent via email           |
| `ShowcaseBook` | Demo books not for sale                         |

---

## 🧩 Class Structure

### `Book` (abstract)
- ISBN, Title, PublishedYear, Price
- `IsForSale` virtual property

### `PaperBook` : `Book`
- `CurrentStock`
- Overrides `IsForSale`

### `EBook` : `Book`
- `FileType`

### `ShowcaseBook` : `Book`
- Always `IsForSale = false`

### `BookInventory`
- Manages book collection
- Methods:
  - `AddBook(Book)`
  - `RemoveOutdatedBooks(int years)`
  - `BuyBook(string isbn, int quantity, string email, string address)`

### `QuantumBookstoreFullTest`
- Console-based test for:
  - Adding books
  - Removing outdated books
  - Buying books

---

## 🧪 How to Run

1. Open the project in Visual Studio or any C# IDE
2. Set `QuantumBookstoreFullTest` as the startup class
3. Run the project
4. Observe output in the console

---

## 📦 Sample Output
<img width="1251" height="776" alt="image" src="https://github.com/user-attachments/assets/f822e03a-b248-4afc-8d90-86ad33682d22" />


