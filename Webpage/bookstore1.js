$(document).ready(function()
{
    let getdata = [];
    let bookShownCount = 0; 
    let booklimit = 6;
    //get data from book.json file
    function fetchBooks() {
    $.ajax({
        url : 'https://localhost:7192/api/books',
        method : 'GET',
        dataType : 'json',
        success : function(data){
            getdata = data;
            loadBooks();
            loadSearchFunctionality();
            loadMoreBooks();
        }, 
        error: function(error)
        {
            console.error('Error fetching book data', error);
        }

    });
}

    fetchBooks();

    // display books
    function displayBooks(books) {
        let result = '';
        books.forEach(function(book) {
            result += `<div class="book">
                <img src="${book.imageUrl}" alt="${book.title}" class="book-image">
                <p class="title">${book.title}</p>
                <h2 class="author">${book.author}</h2>
                <p class="description">${book.description}</p>
                <button class="buy">Add to cart</button>
                </div>`;
        });
        $('.featured-books').append(result);
        bookShownCount += books.length;
    }
    
    let startCounter = 1;

    function loadBooks()
    {
        // logic to control count of book shown
        let startIndex = (startCounter - 1) * booklimit;
        let endIndex = startCounter * booklimit;
        let currentBookDisplay = getdata.slice(startIndex,endIndex);

        displayBooks(currentBookDisplay);

        if(bookShownCount >= getdata.length)
        {
            $('#load-more').hide();
                if($('.no-more-data').length === 0){
                    $('.featured-books').append(`<p class = "no-more-data">No More data to show</p>`);
                }
        }
        startCounter++;
    }

    //// search handling
    function loadSearchFunctionality()
    {
        $('#search-bar').on('keyup', function(e)
        {
            let data = $(this).val().toLowerCase();
            let matchedData = getdata.filter(function(book)
            {
                return book.title.toLowerCase().includes(data);
            });

            $('.featured-books').empty(); //clear out prev data
            bookShownCount = 0;

            if(matchedData.length > 0)
            {
                displayBooks(matchedData);
            }else
            {
                $('.featured-books').append(`<p class = "not-matched">No Matching books found</p>`);
            }

            if(startCounter * booklimit < matchedData.length)
            {
                $('#load-more').show();
                $('.no-more-data').remove();
            }else{
                $('#load-more').hide();
                if($('.not-matched').length === 0 && $('.no-more-data').length === 0)
                {
                    $('.featured-books').append(`<p class = "no-more-data">No More data to show</p>`);
                }
            }

            if(e.key === 'Enter')
            {
                $('html, body').animate({
                    scrollTop: $('.featured-books').offset().top
                },500);
            }

        });
    }

    function loadMoreBooks()
    {
        $('#load-more').on('click', function()
        {
            loadBooks();
        });
    }

     // Handle form of adding new books
     $('#add-book-form').on('submit', function(e) {
        e.preventDefault();
        let newBook = {
            title: $('#title').val(),
            author: $('#author').val(),
            description: $('#description').val(),
            imageUrl: $('#imageUrl').val()
        };
        $.ajax({
            url: 'https://localhost:7192/api/books',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(newBook),
            success: function(addedBook) {
                getdata.push(addedBook);
                $('.featured-books').empty();
                startCounter = 1;
                bookShownCount = 0;
                loadBooks();
                $('#add-book-form')[0].reset();
            },
            error: function(error) {
                console.error('Error adding book', error);
            }
        });
    });

});