$(document).ready(function() {
    let getBooks = []; 
    let pageLimit = 3; // set page limit
    let startCounter = 1; 
    let booksShown = 0; 

    // GET data from books.json
    $.ajax({
        url: 'books.json',
        method: 'GET',
        dataType: 'json',
        success: function(data) 
        {
            getBooks = data;
            loadBooks(); // initial books load
 
    // (book searching)
    $('#search-bar').on('keyup', function(e) {
        let query = $(this).val().toLowerCase();
        let matchedBookss = getBooks.filter(function(book) 
        {
            return (book.title.toLowerCase().includes(query));
        });

        $('.featured-books').empty(); // Clear previous results
        booksShown = 0; // 

        if (matchedBookss.length > 0) 
        {
            displayBooks(matchedBookss);
        } 
        else 
        {
            $('.featured-books').html('<p class="not-matched">No matching books found.</p>');
        }

        // Check if there are left after filtering
        if (startCounter*pageLimit < matchedBookss.length) 
        {
            $('#load-more').show();
            $('.no-more-data').remove(); // Remove no more data message if present
        } 
        else 
        {
            $('#load-more').hide();
            if ($('.no-more-data').length === 0 && $('.not-matched').length === 0) {
                $('.featured-books').append('<p class="no-more-data">No more data to show</p>'); 
            }
        }

        // If the Enter key is pressed, focus on featured-books section
        if (e.key === 'Enter') 
        {
            $('html, body').animate({
                scrollTop: $('.featured-books').offset().top
            }, 500);
        }
    });

          // Event listener ---> "Load More" button

            $('#load-more').on('click', function() 
            {
                loadBooks();
            });
        },
        error: function(err) 
        {
            console.error('Error fetching book data:', err);
        }
});
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
        booksShown += books.length;
    }

    // Function to load more books
    function loadBooks() 
    {
        let startIndex = (startCounter - 1) * pageLimit;
        let endIndex = startCounter * pageLimit;
        let booksToDisplay = getBooks.slice(startIndex, endIndex);

        displayBooks(booksToDisplay);

        if (booksShown >= getBooks.length) {
            $('#load-more').hide(); // Hide the button if no more books to load
            $('.featured-books').append('<p class="no-more-data">No more data</p>'); // Show no more data message
        }

        startCounter++;
    }
});
