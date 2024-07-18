$(document).ready(function() {
    let bookData = []; // Store the fetched book data
    let itemsPerPage = 5; // Number of items to show per load
    let currentPage = 1; // Current page
    let totalBooksDisplayed = 0; // Track total books displayed

    // Function to display books
    function displayBooks(books) {
        let results = '';

        books.forEach(function(book) {
            results += `<div class="book">
                            <img src="${book.image}" alt="${book.title}" class="book-image">
                            <p class="title">${book.title}</p>
                            <p class="author">${book.author}</p>
                            <p class="description">${book.description}</p>
                            <button class="buy">Add to cart</button>
                        </div>`;
        });

        $('.featured-books').append(results);
        totalBooksDisplayed += books.length;
    }

    // Function to load more books
    function loadMoreBooks() {
        let startIndex = (currentPage - 1) * itemsPerPage;
        let endIndex = currentPage * itemsPerPage;
        let booksToDisplay = bookData.slice(startIndex, endIndex);

        displayBooks(booksToDisplay);

        if (totalBooksDisplayed >= bookData.length) {
            $('#load-more').hide(); // Hide the button if no more books to load
            $('.featured-books').append('<p class="no-more-data">No more data</p>'); // Show no more data message
        }

        currentPage++;
    }

    // Fetch book data from books.json
    $.ajax({
        url: 'books.json',
        method: 'GET',
        dataType: 'json',
        success: function(data) {
            bookData = data;
            loadMoreBooks(); // Initial load

            // Event listener for keyup event on the search bar
            $('#search-bar').on('keyup', function(e) {
                let query = $(this).val().toLowerCase();
                let filteredBooks = bookData.filter(function(book) {
                    return book.title.toLowerCase().includes(query);
                });

                $('.featured-books').empty(); // Clear previous results
                totalBooksDisplayed = 0; // Reset total books displayed

                if (filteredBooks.length > 0) {
                    displayBooks(filteredBooks);
                } else {
                    $('.featured-books').html('<p class="no-matching-books">No matching books found.</p>');
                }

                // Check if there are more books to load after filtering
                if (currentPage * itemsPerPage < filteredBooks.length) {
                    $('#load-more').show();
                    $('.no-more-data').remove(); // Remove no more data message if present
                } else {
                    $('#load-more').hide();
                    if ($('.no-more-data').length === 0 && $('.no-matching-books').length === 0) {
                        $('.featured-books').append('<p class="no-more-data">No more data</p>'); // Show no more data message
                    }
                }

                // If the Enter key is pressed, scroll to the featured-books section
                if (e.key === 'Enter') {
                    $('html, body').animate({
                        scrollTop: $('.featured-books').offset().top
                    }, 500);
                }
            });

            // Event listener for click event on the "Load More" button
            $('#load-more').on('click', function() {
                loadMoreBooks();
            });
        },
        error: function(err) {
            console.error('Error fetching book data:', err);
        }
    });
});
