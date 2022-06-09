package com.nathenpadilla.issuetracker.requests;

import java.util.Arrays;

public class CommentUpdateRequest {
	private Integer id;
	private byte[] rowversion;
	
	public CommentUpdateRequest(){}
	
	public Integer getId() {
		return id;
	}
	public void setId(Integer id) {
		this.id = id;
	}
	public byte[] getRowversion() {
		return rowversion;
	}
	public void setRowversion(byte[] rowversion) {
		this.rowversion = rowversion;
	}

	@Override
	public String toString() {
		return "CommentUpdateRequest [id=" + id + ", rowversion=" + Arrays.toString(rowversion) + "]";
	}
	
	
	
}
