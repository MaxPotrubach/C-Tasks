CREATE TABLE books (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(100) NOT NULL,
    author VARCHAR(100) NOT NULL,
    publication_year INT,
    is_available BOOLEAN DEFAULT TRUE
);
ALTER TABLE books ADD COLUMN genre VARCHAR(50);

INSERT INTO books (title, author, publication_year, genre) VALUES
('1984', 'George Orwell', 1949, 'Science Fiction'),
('To Kill a Mockingbird', 'Harper Lee', 1960, 'Fiction'),
('Pride and Prejudice', 'Jane Austen', 1813, 'Romance');

UPDATE books SET is_available = FALSE WHERE id = 1;

DELIMITER //
CREATE PROCEDURE GetAvailableBooks()
BEGIN
    SELECT * FROM books WHERE is_available = TRUE;
END //
DELIMITER ;

CALL GetAvailableBooks();