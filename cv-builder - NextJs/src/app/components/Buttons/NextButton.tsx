import React from 'react'

type NextButtonProps = {
  onClick?: () => void
}

export default function NextButton({ onClick }: NextButtonProps) {
  return (
    <div className="text-right">
        <button
          type="submit"
          className="bg-blue-600 text-white px-5 py-2 rounded-lg hover:bg-blue-700 transition"
          onClick={onClick}
        >
          Tovább →
        </button>
      </div>
  )
}
