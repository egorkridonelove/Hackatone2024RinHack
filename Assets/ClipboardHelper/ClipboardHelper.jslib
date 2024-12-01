// ClipboardHelper.jslib
mergeInto(LibraryManager.library, {
    CopyToClipboard: function (textPtr, textLength) {
        var text = Pointer_stringify(textPtr, textLength);
        navigator.clipboard.writeText(text).then(function() {
            console.log('Текст скопирован в буфер обмена: ' + text);
        }).catch(function(err) {
            console.error('Ошибка при копировании текста: ', err);
        });
    }
});
