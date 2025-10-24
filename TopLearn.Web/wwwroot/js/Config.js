window.ckEditorConfig = {
    language: 'fa',
    direction: 'rtl',
    toolbar: {
        items: [
            'undo', 'redo', '|',
            'heading', '|',
            'bold', 'italic', 'underline', 'strikethrough', 'subscript', 'superscript', '|',
            'link', '|',
            'numberedList', 'bulletedList', '|',
            'outdent', 'indent', '|',
            'alignment', '|',
            'insertTable', 'blockQuote', 'imageUpload', 'mediaEmbed', 'horizontalLine', 'specialCharacters', '|',
            'fontColor', 'fontBackgroundColor', 'fontSize', 'fontFamily'
        ],
        shouldNotGroupWhenFull: true
    },
    image: {
        toolbar: [
            'imageTextAlternative', 'imageStyle:alignLeft', 'imageStyle:full', 'imageStyle:alignRight'
        ],
        upload: {
            types: ['jpeg', 'png', 'gif', 'bmp', 'webp']
        }
    },
    simpleUpload: {
        uploadUrl: '/file-upload',
        headers: {
            'X-CSRF-TOKEN': document.querySelector('input[name="__RequestVerificationToken"]')?.value || ''
        }
    },
    table: {
        contentToolbar: ['tableColumn', 'tableRow', 'mergeTableCells']
    }
};
