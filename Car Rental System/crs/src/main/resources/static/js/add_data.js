function addProperty(containerId) {
    const container = document.getElementById(containerId);
    const count = container.querySelectorAll('.additional-property').length + 1;

    const label = document.createElement('label');
    label.setAttribute('for', `${containerId}-property${count}`);

    const input = document.createElement('input');
    input.setAttribute('type', 'text');
    input.setAttribute('id', `${containerId}-property${count}`);
    input.setAttribute('value', '');

    const removeButton = document.createElement('button');
    removeButton.classList.add('removeData');
    removeButton.setAttribute('type', 'button');
    removeButton.setAttribute('onclick', 'removeProperty(this)');
    removeButton.textContent = '-';
    
    const newProperty = document.createElement('div');
    newProperty.classList.add('additional-property');
    newProperty.appendChild(input);
    newProperty.appendChild(removeButton);
    newProperty.appendChild(label);

    container.appendChild(newProperty);
}

function removeProperty(button) {
    const propertyDiv = button.parentElement;
    propertyDiv.parentElement.removeChild(propertyDiv);
}

function saveData() {
    const form = document.getElementById('carForm');
    const formData = new FormData(form);

    console.log('Mentett adatok:', Object.fromEntries(formData.entries()));
}