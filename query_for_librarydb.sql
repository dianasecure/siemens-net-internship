CREATE TABLE "Books" (
    id SERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255) NOT NULL,
    quantity INT NOT NULL, -- all books (books in stock + books borrowed)
    stock INT NOT NULL     -- books in stock
);


CREATE TABLE "Users" (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    surname VARCHAR(100) NOT NULL
);

select * from "Users"

CREATE TABLE "UserBooks"(
	id SERIAL PRIMARY KEY,
    user_id INT NOT NULL REFERENCES "Users"(id),
    book_id INT NOT NULL REFERENCES "Books"(id),
    borrowed_at TIMESTAMP NOT NULL DEFAULT NOW(),
    returned_at TIMESTAMP NULL
)



select * from "UserBooks"

select * from "Books"

select * from "Users"



